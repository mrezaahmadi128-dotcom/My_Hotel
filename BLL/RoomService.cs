using DAL;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTOs;
using Models.Entities;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using OperationResult = Models.OperationResult;

namespace BLL;

public class RoomService
{
    public async Task<OperationResult<List<Room>>> GetRoomsAsync()
    {
       using var db=DbConnectionFactory.Create();
        var room= await db.Rooms.ToListAsync();
        return OperationResult<List<Room>>.Ok(room);
    }
    public async Task<OperationResult> AddRoom(RoomDto room)
    {
        throw new NotImplementedException();
    }
    //public OperationResult ValidateData(RoomDto room)
    //{
    //    if (room == null)
    //    {
    //        return OperationResult.Failed("لطفاً اطلاعات را وارد کنید");
    //    }
    //    if (room.RoomNumber || room.RoomNumber)
    //    {
    //        return OperationResult.Failed("لطفاً نام خود را صحیح وارد کنید");
    //    }
    //    if (string.IsNullOrEmpty(room.LastName) || room.LastName.Length < 5)
    //    {
    //        return OperationResult.Failed("لطفاً نام خانوادگی خود را صحیح وارد کنید");
    //    }
    //    if (string.IsNullOrEmpty(room.NationalCode) || room.NationalCode.Length != 10)
    //    {
    //        return OperationResult.Failed("لطفاً کدملی خود را صحیح وارد کنید");
    //    }
    //    if (string.IsNullOrEmpty(room.MobileNumber) || room.MobileNumber.Length != 11)
    //    {
    //        return OperationResult.Failed("لطفاً شماره موبایل خود را صحیح وارد کنید");
    //    }
    //    return OperationResult.Ok();

    //}
}
