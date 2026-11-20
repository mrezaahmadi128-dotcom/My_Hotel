namespace HotelManagement_core
{
    partial class FrmGuest
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
            btnSave = new Button();
            txtfirstName = new TextBox();
            txtlastName = new TextBox();
            txtnationalCode = new TextBox();
            txtmobileNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13F);
            btnSave.Location = new Point(148, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 47);
            btnSave.TabIndex = 0;
            btnSave.Text = "ثبت مهمان";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // txtfirstName
            // 
            txtfirstName.Location = new Point(148, 95);
            txtfirstName.Multiline = true;
            txtfirstName.Name = "txtfirstName";
            txtfirstName.Size = new Size(206, 41);
            txtfirstName.TabIndex = 1;
            // 
            // txtlastName
            // 
            txtlastName.Location = new Point(148, 182);
            txtlastName.Multiline = true;
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(206, 41);
            txtlastName.TabIndex = 2;
            // 
            // txtnationalCode
            // 
            txtnationalCode.Location = new Point(148, 269);
            txtnationalCode.Multiline = true;
            txtnationalCode.Name = "txtnationalCode";
            txtnationalCode.Size = new Size(206, 41);
            txtnationalCode.TabIndex = 3;
            // 
            // txtmobileNumber
            // 
            txtmobileNumber.Location = new Point(148, 361);
            txtmobileNumber.Multiline = true;
            txtmobileNumber.Name = "txtmobileNumber";
            txtmobileNumber.Size = new Size(206, 41);
            txtmobileNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(318, 64);
            label1.Name = "label1";
            label1.Size = new Size(36, 28);
            label1.TabIndex = 5;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(237, 151);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 6;
            label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(286, 238);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 7;
            label3.Text = "کدملی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(237, 330);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 8;
            label4.Text = "شماره موبایل";
            // 
            // FrmGuest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 559);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtmobileNumber);
            Controls.Add(txtnationalCode);
            Controls.Add(txtlastName);
            Controls.Add(txtfirstName);
            Controls.Add(btnSave);
            Name = "FrmGuest";
            Text = "FrmGuest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtfirstName;
        private TextBox txtlastName;
        private TextBox txtnationalCode;
        private TextBox txtmobileNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}