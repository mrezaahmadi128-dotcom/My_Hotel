using BLL;
using Models;
using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement_core;

public partial class FrmGuest : Form
{
    private Guest _guest;
    private GuestService _guestService;
    public FrmGuest(GuestService guestservice)
    {
        InitializeComponent();
        _guestService = guestservice;
    }
    public FrmGuest(Guest guest,GuestService guestservice)
    {
        InitializeComponent();
        _guestService= guestservice;
        _guest = guest;
        txtfirstName.Text = guest.FirstName;
        txtlastName.Text = guest.LastName;
        txtmobileNumber.Text = guest.MobileNumber;
        txtnationalCode.Text = guest.NationalCode;
    }
    private OperationResult ValideData(GuestDto guest)
    {
        if(string.IsNullOrWhiteSpace(guest.FirstName))
        {
            return OperationResult.Failed("لطفا نام خود را صحیح وارد کنید");
        }
        if(string.IsNullOrWhiteSpace(guest.LastName) )
        {
            return OperationResult.Failed("لطفا نام خانوادگی خود را صحیح وارد کنید");
        }
        if(string.IsNullOrWhiteSpace(guest.NationalCode) )
        {
            return OperationResult.Failed("لطفا کدملی  خود را صحیح وارد کنید");
        }
        if(string.IsNullOrWhiteSpace(guest.MobileNumber))
        {
            return OperationResult.Failed("لطفا شماره تلفن خود را صحیح وارد کنید");
        }
        return OperationResult.Ok();
        
    }
    private async void button1_Click(object sender, EventArgs e)
    {
        
        
        
        if (_guest == null)
        {
            var guestDto = new GuestDto()
            {
                FirstName = txtfirstName.Text,
                LastName = txtlastName.Text,
                NationalCode = txtnationalCode.Text,
                MobileNumber = txtmobileNumber.Text,
            };
            var result = ValideData(guestDto);
            if (!result.Success)
            {
                MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var res = await _guestService.AddGuestAsync(guestDto);
            if (!res.Success)
            {
                MessageBox.Show(res.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("مهمان ثبت شد!");
            Close();
        }
        else
        {
            var guestDto = new GuestDto()
            {
                Id=_guest.Id,
                FirstName = txtfirstName.Text,
                LastName = txtlastName.Text,
                NationalCode = txtnationalCode.Text,
                MobileNumber = txtmobileNumber.Text,
            };
            var result = ValideData(guestDto);
            if (!result.Success)
            {
                MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var res =await _guestService.UpdateGuestAsync(guestDto);
            if(!res.Success)
            {
                MessageBox.Show(res.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("ویرایش انجام شد");
            Close() ;
        }
    }
}
