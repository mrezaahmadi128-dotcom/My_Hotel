using BLL;
using Models;
using Models.DTOs;
using System.ClientModel.Primitives;
using OperationResult = Models.OperationResult;

namespace HotelManagement_core;

public partial class FrmLogin : Form
{
    private AuthenticationService _authenticationService;
    public FrmLogin()
    {
        InitializeComponent();
        _authenticationService = new AuthenticationService();
    }
    private void lblTitle_Click(object sender, EventArgs e)
    {

    }

    private void txtUserName_TextChanged(object sender, EventArgs e)
    {

    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {

    }
    private bool _isPasswordVisible = false;
    private void btnTogglePassword_Click(object sender, EventArgs e)
    {
        _isPasswordVisible = !_isPasswordVisible;
        txtPassword.UseSystemPasswordChar = !_isPasswordVisible;
        btnTogglePassword.Text = _isPasswordVisible ? "◉" : "◎";
        txtPassword.Focus();
    }

    private void btnLogin_MouseEnter(object sender, EventArgs e)
    {
        btnLogin.BackColor = Color.FromArgb(232, 196, 127);
    }

    private void btnLogin_MouseLeave(object sender, EventArgs e)
    {
        btnLogin.BackColor = Color.FromArgb(214, 173, 96);
    }

    private void lblPassword_Click(object sender, EventArgs e)
    {

    }

    private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        new FrmRegister().ShowDialog();
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        var login = new LoginDto()
        {
            UserName = txtUserName.Text,
            Password = txtPassword.Text
        };
        var result = ValidateData(login);
        if (!result.Success)
        {
            MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var loginResult = await _authenticationService.LoginAsync(login);
        if (!loginResult.Success)
        {
            MessageBox.Show(loginResult.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var frm = new FrmDashboard(loginResult.Data);
        frm.Show();

    }
    private OperationResult ValidateData(LoginDto login)
    {
        if (string.IsNullOrWhiteSpace(login.UserName))
        {
            txtUserName.Focus();
            return OperationResult.Failed("لطفاً نام کاربری خود را وارد کنید");
        }
        if (string.IsNullOrWhiteSpace(login.Password))
        {
            txtPassword.Focus();
            return OperationResult.Failed("لطفاً رمرز عبور خود را وارد کنید");
        }
        return OperationResult.Ok();
    }

    private async void button1_Click_1(object sender, EventArgs e)
    {

    }
}
