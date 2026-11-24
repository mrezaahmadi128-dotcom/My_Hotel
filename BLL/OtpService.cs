using BLL.Abstraction;
using BLL.Security;
using DAL;
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
    public OtpService()
    {
        
    }
    public async Task<OperationResult> GenerateAndStorade(string mobileNumber)
    {
        var verificatio = new PhoneVerification()
        {
            CodeHash = OtpGenerator.GenerateCode(),
            MobileNumber = mobileNumber,
            CreatedAtUtc = DateTime.UtcNow,
            ExpiresAtUtc = DateTime.UtcNow,
            FailedAttempts = 0,
            IsUsed = true,
        };
        var db=DbConnectionFactory.Create();
        db.PhoneVerifications.Add(verificatio);
        await db.SaveChangesAsync();
        return OperationResult.Ok();


    }
    public OperationResult VerifyCode(string inputCode,string mobileNumber, out bool f)
    {
        if(string.IsNullOrWhiteSpace(inputCode))
        {
            f= false;
            return OperationResult.Failed("کدی برای تایید وجود ندارد");
        }
        if(mobileNumber!=_molbileNumber)
        {
            f = false;
            return OperationResult.Failed("شماره موبایل مطابقت ندارد");
        }
        if (DateTimeOffset.UtcNow >= _expiresAt)
        { 
            ClearCode();
            f = true;
            return OperationResult.Failed("کد تایید منقضی شده");
        }
        if(MaxAttemps<=_attempCount)
        {
            ClearCode();
            f = true;
            return OperationResult.Failed("تعداد تلاش‌های مجاز تمام شده است");
        }
        if (!string.Equals(_code, inputCode, StringComparison.Ordinal))
        {
            _attempCount++;
            if (_attempCount >= MaxAttemps)
            {
                ClearCode();
                f = true;
                return OperationResult.Failed("تعداد تلاش‌های مجاز تمام شده است");
            }
            f = false;
            return OperationResult.Failed("کد وارده شد صحیح نیست");
        }
        ClearCode();
        f = true;
        return OperationResult.Ok();

    }
    public void ClearCode()
    {
        _code = null;
        _molbileNumber = null;
        _expiresAt = default;
        _attempCount= 0;
    }
}
