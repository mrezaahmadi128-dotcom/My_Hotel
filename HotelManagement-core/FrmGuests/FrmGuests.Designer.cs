namespace HotelManagement_core
{
    partial class FrmGuests
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnremove = new Button();
            txtremove = new TextBox();
            btnEdite = new Button();
            txtedite = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(836, 188);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(49, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnremove
            // 
            btnremove.Font = new Font("Segoe UI", 11F);
            btnremove.Location = new Point(186, 248);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(96, 38);
            btnremove.TabIndex = 2;
            btnremove.Text = "-";
            btnremove.UseVisualStyleBackColor = true;
            btnremove.Click += btnremove_Click;
            // 
            // txtremove
            // 
            txtremove.Location = new Point(308, 254);
            txtremove.Name = "txtremove";
            txtremove.Size = new Size(144, 27);
            txtremove.TabIndex = 3;
            // 
            // btnEdite
            // 
            btnEdite.Font = new Font("Segoe UI", 11F);
            btnEdite.Location = new Point(624, 248);
            btnEdite.Name = "btnEdite";
            btnEdite.Size = new Size(96, 38);
            btnEdite.TabIndex = 4;
            btnEdite.Text = "ویرایش";
            btnEdite.UseVisualStyleBackColor = true;
            btnEdite.Click += btnEdite_Click;
            // 
            // txtedite
            // 
            txtedite.Location = new Point(741, 254);
            txtedite.Name = "txtedite";
            txtedite.Size = new Size(144, 27);
            txtedite.TabIndex = 5;
            // 
            // FrmGuests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 528);
            Controls.Add(txtedite);
            Controls.Add(btnEdite);
            Controls.Add(txtremove);
            Controls.Add(btnremove);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "FrmGuests";
            Text = "FrmGuests";
            Load += FrmGuests_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnremove;
        private TextBox txtremove;
        private Button btnEdite;
        private TextBox txtedite;
    }
}