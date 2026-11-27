using BLL.Abstraction;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement_core;

internal class WindowsNotificationSender : ISmsSender
{
    private readonly NotifyIcon _notifyIcon;
    public WindowsNotificationSender()
    {
        _notifyIcon= new NotifyIcon();
        _notifyIcon.Visible = true;
    }
    public async Task<OperationResult> SendAsync(string mobileNumber, string message)
    {
        if (string.IsNullOrWhiteSpace(mobileNumber))
        {
            return OperationResult.Failed("شماره موبایل موجود نمی باشد");
        }
        if (string.IsNullOrWhiteSpace(message))
        {
            return OperationResult.Failed("پیامی برای ارسال وجود ندارد");
        }
         _notifyIcon.ShowBalloonTip(10000,"کد تایید هتل",$"{message} : {mobileNumber} کد تایید برای",ToolTipIcon.Info);
        return OperationResult.Ok();
    }
}
