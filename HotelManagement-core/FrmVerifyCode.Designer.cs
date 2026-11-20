namespace HotelManagement_core
{
    partial class FrmVerifyCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnsendCode = new Button();
            btnRegister = new Button();
            lblMessage = new Label();
            txtCode = new TextBox();
            lblok = new Label();
            txtMobileNumber = new TextBox();
            lblPassword = new Label();
            lblDescription = new Label();
            lblRegister = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 47, 59);
            panel1.Controls.Add(btnsendCode);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(lblMessage);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(lblok);
            panel1.Controls.Add(txtMobileNumber);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblRegister);
            panel1.Location = new Point(179, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 442);
            panel1.TabIndex = 0;
            // 
            // btnsendCode
            // 
            btnsendCode.BackColor = Color.FromArgb(214, 173, 96);
            btnsendCode.Cursor = Cursors.Hand;
            btnsendCode.FlatStyle = FlatStyle.Flat;
            btnsendCode.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnsendCode.ForeColor = Color.FromArgb(23, 26, 33);
            btnsendCode.Location = new Point(20, 151);
            btnsendCode.Name = "btnsendCode";
            btnsendCode.Size = new Size(103, 45);
            btnsendCode.TabIndex = 23;
            btnsendCode.Text = "ارسال کد";
            btnsendCode.UseVisualStyleBackColor = false;
            btnsendCode.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(214, 173, 96);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnRegister.ForeColor = Color.FromArgb(23, 26, 33);
            btnRegister.Location = new Point(121, 356);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(319, 52);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "تایید کد و ثبت نام";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.FromArgb(242, 243, 245);
            lblMessage.Location = new Point(461, 309);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 21;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.FromArgb(32, 38, 48);
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Segoe UI", 12F);
            txtCode.ForeColor = Color.FromArgb(242, 243, 245);
            txtCode.Location = new Point(149, 251);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.PasswordChar = '*';
            txtCode.Size = new Size(375, 45);
            txtCode.TabIndex = 20;
            txtCode.UseSystemPasswordChar = true;
            txtCode.Visible = false;
            // 
            // lblok
            // 
            lblok.AutoSize = true;
            lblok.BackColor = Color.FromArgb(41, 47, 59);
            lblok.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblok.ForeColor = Color.FromArgb(242, 243, 245);
            lblok.Location = new Point(450, 216);
            lblok.Name = "lblok";
            lblok.Size = new Size(71, 32);
            lblok.TabIndex = 19;
            lblok.Text = "کد تایید";
            lblok.Visible = false;
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.BackColor = Color.FromArgb(32, 38, 48);
            txtMobileNumber.BorderStyle = BorderStyle.FixedSingle;
            txtMobileNumber.Enabled = false;
            txtMobileNumber.Font = new Font("Segoe UI", 12F);
            txtMobileNumber.ForeColor = Color.FromArgb(242, 243, 245);
            txtMobileNumber.Location = new Point(149, 154);
            txtMobileNumber.Multiline = true;
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.PasswordChar = '*';
            txtMobileNumber.RightToLeft = RightToLeft.Yes;
            txtMobileNumber.Size = new Size(375, 45);
            txtMobileNumber.TabIndex = 18;
            txtMobileNumber.TextAlign = HorizontalAlignment.Right;
            txtMobileNumber.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(41, 47, 59);
            lblPassword.Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblPassword.ForeColor = Color.FromArgb(242, 243, 245);
            lblPassword.Location = new Point(420, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(104, 32);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "شماره موبایل";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(41, 47, 59);
            lblDescription.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lblDescription.ForeColor = Color.FromArgb(163, 170, 183);
            lblDescription.Location = new Point(157, 61);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(231, 23);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "اطلاعات شما دریافت شد. کد تایید را وارد کنید";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.FromArgb(41, 47, 59);
            lblRegister.Font = new Font("B Nazanin", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblRegister.ForeColor = Color.FromArgb(242, 243, 245);
            lblRegister.Location = new Point(215, 10);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(104, 51);
            lblRegister.TabIndex = 11;
            lblRegister.Text = "ثبت نام";
            // 
            // FrmVerifyCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 26, 33);
            ClientSize = new Size(898, 527);
            Controls.Add(panel1);
            Name = "FrmVerifyCode";
            Text = "FrmVerifyCode";
            Load += FrmVerifyCode_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblRegister;
        private Label lblDescription;
        private Label lblPassword;
        private TextBox txtMobileNumber;
        private Label lblMessage;
        private TextBox txtCode;
        private Label lblok;
        private Button btnRegister;
        private Button btnsendCode;
    }
}