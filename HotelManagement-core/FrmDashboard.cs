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
    public partial class FrmDashboard : Form
    {
        private LoginResultDto _loginResultDto;
        public FrmDashboard()
        {
            InitializeComponent();
        }
        public FrmDashboard(LoginResultDto login)
        {
            InitializeComponent();
            _loginResultDto = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmGuests().Show();
        }
    }
}
