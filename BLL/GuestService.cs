using DAL;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL;

public class GuestService
{
    
    public GuestService()
    {
        
    }
    public async Task<OperationResult<List<Guest>>> GetGuestsAsync()
    {
        var db=DbConnectionFactory.Create();
        var guests=await db.Guests.ToListAsync();
        return OperationResult<List<Guest>>.Ok(guests);
    }
    public async Task<OperationResult> AddGuestAsync(GuestDto guestDto)
    {
       var db = DbConnectionFactory.Create();
        var result=ValidateData(guestDto);
        if (!result.Success)
        {
            return result;
        }
        var exist = await db.Guests.AnyAsync(g => g.NationalCode == guestDto.NationalCode);
        if (exist)
        {
            return OperationResult.Failed("کدملی وارد شده تکراری می باشد");
        }
        exist = await db.Guests.AnyAsync(g=>g.MobileNumber == guestDto.MobileNumber);
        if (exist)
        {
            return OperationResult.Failed("شماره موبایل وارد شده تکراری می باشد");
        }
        var guest=new Guest(guestDto.FirstName, guestDto.LastName,guestDto.NationalCode,guestDto.MobileNumber);
        db.Guests.Add(guest);
        await db.SaveChangesAsync();
        return OperationResult.Ok();

    }
    public async Task<OperationResult> RemoveGuestAsync(int id)
    {
        var db = DbConnectionFactory.Create();
        var exist =await db.Guests.AnyAsync(g=>g.Id == id);
        if (!exist)
        {
            return OperationResult.Failed("آیدی وارد شده موجود نمی باشد");
        }
        var guest=await db.Guests.SingleOrDefaultAsync(g=>g.Id == id);
        var reserv = await db.Reservations.AnyAsync(g => g.GuestId == id);
        if(reserv)
        {
            return OperationResult.Failed(" این مهمان دارای رزرو هست");
        }
        db.Guests.Remove(guest);
        await db.SaveChangesAsync();
        return OperationResult.Ok();
    }
    public async Task<OperationResult<Guest>> GetGuestAsync(int id)
    {
        var db = DbConnectionFactory.Create();
        var guest =await db.Guests.FirstOrDefaultAsync(g=>g.Id==id);
        if(guest==null)
        {
            return OperationResult<Guest>.Failed("آیدی وارد شده موجود نمی باشد");
        }
        return OperationResult<Guest>.Ok(guest);
    }
    public async Task<OperationResult> UpdateGuestAsync(GuestDto guestDto)
    {
        var db = DbConnectionFactory.Create();
        var oldGuest = await db.Guests.SingleAsync(g=>g.Id== guestDto.Id); 
        var exist=await db.Guests.AnyAsync(g=>g.NationalCode==guestDto.NationalCode && g.Id!=guestDto.Id);
        if (exist)
        {
            return OperationResult.Failed("کدملی وارد شده تکراری می باشد");
        }
        var result=ValidateData(guestDto);
        if(!result.Success)
        {
            return result;
        }
        oldGuest.FirstName = guestDto.FirstName;
        oldGuest.LastName = guestDto.LastName;
        oldGuest.NationalCode = guestDto.NationalCode;
        oldGuest.MobileNumber = guestDto.MobileNumber;
        await db.SaveChangesAsync();
        return OperationResult.Ok();
    }
    public OperationResult ValidateData(GuestDto guest)
    {
        if(guest == null)
        {
            return OperationResult.Failed("لطفاً اطلاعات را وارد کنید");
        }
        if (string.IsNullOrEmpty(guest.FirstName) || guest.FirstName.Length<3)
        {
            return OperationResult.Failed("لطفاً نام خود را صحیح وارد کنید");
        }
        if (string.IsNullOrEmpty(guest.LastName) || guest.LastName.Length<5)
        {
            return OperationResult.Failed("لطفاً نام خانوادگی خود را صحیح وارد کنید");
        }
        if (string.IsNullOrEmpty(guest.NationalCode) || guest.NationalCode.Length!=10)
        {
            return OperationResult.Failed("لطفاً کدملی خود را صحیح وارد کنید");
        }
        if (string.IsNullOrEmpty(guest.MobileNumber) || guest.MobileNumber.Length!=11)
        {
            return OperationResult.Failed("لطفاً شماره موبایل خود را صحیح وارد کنید");
        }
        return OperationResult.Ok();

        }
    }
