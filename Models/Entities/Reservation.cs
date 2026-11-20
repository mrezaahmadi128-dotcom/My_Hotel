using Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities;

public class Reservation
{
    public Reservation(
       int roomId
       , int guestId
       , DateTime dateIn
       , DateTime dateOut)
    {
        RoomId = roomId;
        GuestId = guestId;
        DateIn = dateIn;
        DateOut = dateOut;
    }
    public int Id { get; private set; }
    public int RoomId { get; private set; }
    public Room Room { get; private set; }
    public int GuestId { get; private set; }
    public Guest Guest { get; private set; }
    public DateTime DateIn { get; private set; }
    public DateTime DateOut { get; private set; }
}
