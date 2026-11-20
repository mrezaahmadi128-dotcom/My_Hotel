using BLL.Abstraction;
using BLL.Security;
using Models;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using OperationResult = Models.OperationResult;

namespace BLL;

public class OtpService 
{
    private string _code;
    private string _molbileNumber;
    private DateTimeOffset _expiresAt;
    private int _attempCount;
    private const int Minutes=2;
    private const int MaxAttemps=5;


    public string GenerateAndStorade(string mobileNumber)
    {
        _code = OtpGenerator.GenerateCode();
        _molbileNumber = mobileNumber;
        _expiresAt = DateTimeOffset.UtcNow.AddMinutes(Minutes);
        _attempCount = 0;
        return _code;
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
