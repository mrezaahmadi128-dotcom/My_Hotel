using BLL;
using Microsoft.Win32;
using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement_core
{
    public partial class FrmVerifyCode : Form
    {
        private RegisterDto _register;
        private string _code;
        OtpService _otp;
        AuthenticationService _service;
        public FrmVerifyCode(RegisterDto register,AuthenticationService service)
        {
            InitializeComponent();
            _register = register;
            txtMobileNumber.Text = _register.MobileNumber;
            _otp = new OtpService();
            _service = service;
        }
        public FrmVerifyCode()
        {

        }
        private OperationResult Validate(string code,string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return OperationResult.Failed("لطفا کد را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(mobileNumber))
            {
                return OperationResult.Failed("لطفا شماره موبایل خود را وارد کنید");
            }
            return OperationResult.Ok();
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            bool valid;
            var result=Validate(txtCode.Text, txtMobileNumber.Text);
            if(!result.Success)
            {
                MessageBox.Show(result.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            var verify=_otp.VerifyCode(txtCode.Text, txtMobileNumber.Text,out valid);
            if (!verify.Success)
            {
                MessageBox.Show(verify.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (valid)
                {
                    btnsendCode.Enabled = true;
                    btnRegister.Visible = false;
                }
                return ;
            }
            var register = await _service.AddRegister(_register);
            MessageBox.Show("ثبت نام انجام شد");
            new FrmLogin().Show();
        }
        private void FrmVerifyCode_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnsendCode.Enabled = false;
             _code = _otp.GenerateAndStorade(_register.MobileNumber);
            lblMessage.Text = "کد تأیید برای شماره موبایل شما صادر شده است.";
           btnRegister.Visible = true;
            txtCode.Visible=true;
            lblok.Visible=true;
            txtCode.Focus();
            
        }
    }
}
