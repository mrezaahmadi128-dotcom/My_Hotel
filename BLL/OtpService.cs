using BLL.Abstraction;
using BLL.Security;
using DAL;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Entities;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using OperationResult = Models.OperationResult;

namespace BLL;

public class OtpService 
{
    private const int Minutes=2;
    private const int MaxAttemps=5;
    private readonly PasswordHasher _passwordHasher = new();
    public OtpService()
    {
        
    }
    public async Task<OperationResult<string>> GenerateAndStorade(string mobileNumber)
    {
        if (string.IsNullOrEmpty(mobileNumber))
        {
            return OperationResult<string>.Failed("شماره موبایل نامعتبر است");
        }

        mobileNumber = mobileNumber.Trim();
        var db = DbConnectionFactory.Create();
        var old = await db.PhoneVerifications
            .Where(p => p.MobileNumber == mobileNumber)
            .Where(p => !p.IsUsed)
            .ToListAsync();
        foreach(var o in old)
        {
            o.IsUsed = true;
        }
        string code = OtpGenerator.GenerateCode();
        var phone = new PhoneVerification()
        {
            CodeHash =_passwordHasher.HashPassword(code) ,
            MobileNumber = mobileNumber,
            CreatedAtUtc = DateTime.UtcNow,
            ExpiresAtUtc = DateTime.UtcNow.AddMinutes(Minutes),
            FailedAttempts = 0,
            IsUsed = false
        };
        db.PhoneVerifications.Add(phone);
        await db.SaveChangesAsync();
        return OperationResult<string>.Ok(code);


    }
    public async Task<OperationResult> VerifyCode(string inputCode,string mobileNumber)
    {
        if(string.IsNullOrWhiteSpace(inputCode))
        {
            return OperationResult.Failed("کدی برای تایید وجود ندارد");
        }
        if(string.IsNullOrWhiteSpace(mobileNumber))
        {
            return OperationResult.Failed("شماره موبایل را وارد کنید");
        }
        mobileNumber=mobileNumber.Trim();
        var db=DbConnectionFactory.Create();
        var phone=await db.PhoneVerifications
            .Where(p=>p.MobileNumber == mobileNumber)
            .Where(p=>!p.IsUsed)
            .OrderByDescending(p=>p.CreatedAtUtc)
            .FirstOrDefaultAsync();
        if (phone == null)
        {
            return OperationResult.Failed("کدی برای این شماره موجود نمی باشد;لطفا دوباره درخواست بفرستید");
        }
        if (phone.ExpiresAtUtc <= DateTime.UtcNow)
        {
            phone.IsUsed = true;
            await db.SaveChangesAsync();
            return OperationResult.Failed("کد منقضی شده است");
        }
        if(phone.FailedAttempts>=MaxAttemps)
        {
            phone.IsUsed=true;
            await db.SaveChangesAsync();
            return OperationResult.Failed("تلاش های مجاز تمام شد؛ کد جدید بگیرید");
        }
        if (!_passwordHasher.VerifyPassword(inputCode, phone.CodeHash))
        {
            phone.FailedAttempts++;
            await db.SaveChangesAsync();
            OperationResult.Failed("کد وارد شده صحیح نمی باشد");
        }
        phone.IsUsed = true;
        await db.SaveChangesAsync();
        return OperationResult.Ok();
    }
    
}
