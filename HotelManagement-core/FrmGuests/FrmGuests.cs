using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement_core
{
    public partial class FrmGuests : Form
    {
        GuestService _guestSrvice;
        public FrmGuests()
        {
            InitializeComponent();
            _guestSrvice = new GuestService();
        }
        public async Task ReloadDatagrid()
        {
            var res=await _guestSrvice.GetGuestsAsync();
            dataGridView1.DataSource = res.Data;
        }
        private void FrmGuests_Load(object sender, EventArgs e)
        {
            ReloadDatagrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmGuest(_guestSrvice).ShowDialog();
            ReloadDatagrid();
        }

        private async void btnremove_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtremove.Text, out int id))
            {
                MessageBox.Show("لطفا ایدی صحیح وارد کنید");
                return;
            }
            DialogResult dialog;
            dialog = MessageBox.Show("آیا از حذف مهمان مطمئن هستید؟", "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == dialog)
            {
                var result = await _guestSrvice.RemoveGuestAsync(id);
                if (!result.Success)
                {
                    MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtremove.Focus();
                    return;
                }
                MessageBox.Show("مهمان حذف شد");
                ReloadDatagrid();
            }

        }

        private async void btnEdite_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtedite.Text, out int id))
            {
                MessageBox.Show("لطفا ایدی صحیح وارد کنید");
                return ;
            }
           var guest= await _guestSrvice.GetGuestAsync(id);
            if(!guest.Success)
            {
                MessageBox.Show(guest.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new FrmGuest(guest.Data,_guestSrvice).ShowDialog();
            ReloadDatagrid();
        }
    }
}
