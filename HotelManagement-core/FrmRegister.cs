using BLL;
using BLL.Security;
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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new RegisterDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                UserName = txtUserName.Text,
                MobileNumber = txtMobileNumber.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text,
            };
            var result = ValidateData(register);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
            var frm=new FrmVerifyCode(register);
            //MessageBox.Show("ثبت اطلاعات انجام شد");
            frm.ShowDialog();
            

        }
        private OperationResult ValidateData(RegisterDto register)
        {
            if (string.IsNullOrWhiteSpace(register.FirstName) || register.FirstName.Length < 3)
            {
                txtFirstName.Focus();
                return OperationResult.Failed("لطفاً نام خود را  صحیح وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(register.LastName))
            {
                txtLastName.Focus();
                return OperationResult.Failed("لطفاً نام خانوادگی خود را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(register.UserName))
            {
                txtUserName.Focus();
                return OperationResult.Failed("لطفاً نام کاربری خود را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(register.MobileNumber))
            {
                txtMobileNumber.Focus();
                return OperationResult.Failed("لطفاً شماره موبایل خود را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(register.Password))
            {
                txtPassword.Focus();
                return OperationResult.Failed("لطفاً رمز عبور خود را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(register.ConfirmPassword) || register.ConfirmPassword!=register.Password)
            {
                txtConfirmPassword.Focus();
                return OperationResult.Failed("رمز عبور و تکرار آن یکسان نیستند");
            }
            return OperationResult.Ok();

        }
    }
}
