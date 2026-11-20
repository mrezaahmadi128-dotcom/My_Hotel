namespace HotelManagement_core
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogin = new Panel();
            btnTogglePassword = new Button();
            label1 = new Label();
            lblDescription = new Label();
            lblWelcome = new Label();
            lnkRegister = new LinkLabel();
            lnkForgoptpassword = new LinkLabel();
            btnLogin = new Button();
            chkRememberMe = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUsername = new Label();
            lblTitle = new Label();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.BackColor = Color.FromArgb(41, 47, 59);
            pnlLogin.Controls.Add(btnTogglePassword);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(lblDescription);
            pnlLogin.Controls.Add(lblWelcome);
            pnlLogin.Controls.Add(lnkRegister);
            pnlLogin.Controls.Add(lnkForgoptpassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(chkRememberMe);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtUserName);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Font = new Font("Swis721 Cn BT", 9F);
            pnlLogin.Location = new Point(253, 33);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(420, 545);
            pnlLogin.TabIndex = 0;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = Color.FromArgb(32, 38, 48);
            btnTogglePassword.Cursor = Cursors.Hand;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.ForeColor = Color.FromArgb(214, 173, 96);
            btnTogglePassword.Location = new Point(45, 279);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(36, 40);
            btnTogglePassword.TabIndex = 13;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = false;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(201, 473);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 12;
            label1.Text = "حساب کاربری ندارید؟";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(41, 47, 59);
            lblDescription.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lblDescription.ForeColor = Color.FromArgb(163, 170, 183);
            lblDescription.Location = new Point(111, 144);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(218, 23);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "برای ورود، اطلاعات حساب خود را وارد کنید";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(41, 47, 59);
            lblWelcome.Font = new Font("B Nazanin", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblWelcome.ForeColor = Color.FromArgb(242, 243, 245);
            lblWelcome.Location = new Point(129, 93);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(157, 51);
            lblWelcome.TabIndex = 10;
            lblWelcome.Text = "خوش آمدید";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("B Nazanin", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lnkRegister.ForeColor = Color.FromArgb(214, 173, 96);
            lnkRegister.LinkColor = Color.FromArgb(214, 173, 96);
            lnkRegister.Location = new Point(120, 473);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(75, 24);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "ثبت نام کنید";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // lnkForgoptpassword
            // 
            lnkForgoptpassword.ActiveLinkColor = Color.Red;
            lnkForgoptpassword.AutoSize = true;
            lnkForgoptpassword.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lnkForgoptpassword.ForeColor = Color.FromArgb(214, 173, 96);
            lnkForgoptpassword.LinkColor = Color.FromArgb(214, 173, 96);
            lnkForgoptpassword.Location = new Point(45, 373);
            lnkForgoptpassword.Name = "lnkForgoptpassword";
            lnkForgoptpassword.Size = new Size(100, 23);
            lnkForgoptpassword.TabIndex = 8;
            lnkForgoptpassword.TabStop = true;
            lnkForgoptpassword.Text = "فراموشی رمز عبور؟";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(214, 173, 96);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnLogin.ForeColor = Color.FromArgb(23, 26, 33);
            btnLogin.Location = new Point(45, 419);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(339, 52);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ورود به سیستم";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            chkRememberMe.ForeColor = Color.FromArgb(163, 170, 183);
            chkRememberMe.Location = new Point(252, 373);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(115, 27);
            chkRememberMe.TabIndex = 3;
            chkRememberMe.Text = "مرا به خاطر بسپار";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(32, 38, 48);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.FromArgb(242, 243, 245);
            txtPassword.Location = new Point(45, 321);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(341, 45);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(41, 47, 59);
            lblPassword.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblPassword.ForeColor = Color.FromArgb(242, 243, 245);
            lblPassword.Location = new Point(322, 292);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(64, 27);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "رمز عبور";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(32, 38, 48);
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.FromArgb(242, 243, 245);
            txtUserName.Location = new Point(45, 233);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(341, 45);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(41, 47, 59);
            lblUsername.Font = new Font("B Nazanin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblUsername.ForeColor = Color.FromArgb(242, 243, 245);
            lblUsername.Location = new Point(311, 203);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 27);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "نام کاربری";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(41, 47, 59);
            lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(214, 173, 96);
            lblTitle.Location = new Point(57, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "HOTEL MANAGEMENT";
            lblTitle.Click += lblTitle_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 26, 33);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(953, 623);
            Controls.Add(pnlLogin);
            Font = new Font("Microsoft YaHei", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FrmLogin";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود به سیستم";
            Load += FrmLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label lblUsername;
        private Label lblTitle;
        private CheckBox chkRememberMe;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private LinkLabel lnkRegister;
        private LinkLabel lnkForgoptpassword;
        private Button btnLogin;
        private Label label1;
        private Label lblDescription;
        private Label lblWelcome;
        private Button btnTogglePassword;
    }
}
