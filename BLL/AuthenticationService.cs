using BLL.Security;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Models;
using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL;

public class AuthenticationService
{
    private HotelDbContext _dbContext;
    private PasswordHasher _passwordHasher=new();
    public AuthenticationService()
    {
        _dbContext = DbConnectionFactory.Create();
    }
    public async Task<OperationResult> AddRegister(RegisterDto register)
    {
        var result = ValidateRegister(register);
        if(!result.Success)
        {
            return result;
        }
         var user = await _dbContext.UserAccounts.AnyAsync(r => r.UserName == register.UserName);
        if (user)
        {
            return OperationResult.Failed("این نام کاربری قبلاً ثبت شده است");
        }
        var passwordHash=_passwordHasher.HashPassword(register.Password);
        var userAccount = new UserAccount(
            register.FirstName.Trim(),
            register.LastName.Trim(),
            register.UserName.Trim(),
            passwordHash,
            register.MobileNumber.Trim());
        _dbContext.UserAccounts.Add(userAccount);
        await _dbContext.SaveChangesAsync();
        return OperationResult.Ok();
    }

    public async Task<OperationResult<LoginResultDto>> LoginAsync(LoginDto login)
    {
        var result=ValidateLogin(login);
        if (!result.Success)
        {
            return OperationResult<LoginResultDto>.Failed(result.Message);
        }
        var user= await _dbContext.UserAccounts
            .SingleOrDefaultAsync(l=>l.UserName == login.UserName);
        if(user==null)
        {
            return OperationResult<LoginResultDto>.Failed("نام کاربری یا رمز عبور نادرست است");
        }
        var verify=_passwordHasher.VerifyPassword(
            login.Password,
            user.PasswordHash
            );
        
        if(!verify)
        {
            return OperationResult<LoginResultDto>.Failed("نام کاربری یا رمز عبور نادرست است");
        }
        var loginResult=new LoginResultDto()
        {
            Id=user.Id,
            FirstName=user.FirstName,
            LastName=user.LastName,
            UserName=user.UserName
        };
        return OperationResult<LoginResultDto>.Ok(loginResult);
    }
    public OperationResult ValidateLogin(LoginDto login)
    {
        if (login == null)
        {
            return OperationResult.Failed("لطفاً اطلاعات را وارد کنید");
        }
        if (string.IsNullOrWhiteSpace(login.UserName) || login.UserName.Trim().Length < 8)
        {
            return OperationResult.Failed(" نام کاربری باید بیش از 8 رقم باشد");
        }
        if (string.IsNullOrWhiteSpace(login.Password) || login.Password.Length < 6)
        {
            return OperationResult.Failed("رمزعبور باید بیش از 6 رقم باشد");
        }
        return OperationResult.Ok();
    }

    public OperationResult ValidateRegister(RegisterDto register)
    {
        if (register == null)
        {
            return OperationResult.Failed("لطفاً اطلاعات را وارد کنید");
        }
        if (string.IsNullOrWhiteSpace(register.FirstName) || register.FirstName.Trim().Length < 3)
        {
            return OperationResult.Failed("لطفاً نام خود را صحیح وارد کنید");
        }
        if (string.IsNullOrWhiteSpace(register.LastName) || register.LastName.Trim().Length < 5)
        {
            return OperationResult.Failed("لطفاً نام خانوادگی خود را صحیح وارد کنید");
        }
        if (string.IsNullOrWhiteSpace(register.UserName) || register.UserName.Trim().Length<8)
        {
            return OperationResult.Failed("لطفاً نام کاربری خود را صحیح وارد کنید");
        }
        if (string.IsNullOrWhiteSpace(register.Password) || register.Password.Length<8)
        {
            return OperationResult.Failed("لطفاً نام رمزعبور خود را صحیح وارد کنید");
        }
        if (string.IsNullOrWhiteSpace(register.ConfirmPassword) || register.ConfirmPassword!=register.Password)
        {
            return OperationResult.Failed("لطفاً رمزعبور خود تکرار را کنید");
        }
        if (string.IsNullOrWhiteSpace(register.MobileNumber) ||
            register.MobileNumber.Length != 11 ||
            !register.MobileNumber.StartsWith("09"))
        {
            return OperationResult.Failed("لطفاً شماره موبایل خود را صحیح وارد کنید");
        }
        return OperationResult.Ok();

    }
}
