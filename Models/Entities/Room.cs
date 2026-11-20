
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities;

public class Room
{
    public Room(
        int roomNumber
        , int capacity
        , decimal price)
    {
        RoomNumber = roomNumber;
        Capacity = capacity;
        Price = price;
    }
    public int Id { get; private set; }
    public int RoomNumber { get; private set; }
    public int Capacity { get; private set; }
    public decimal Price { get; private set; }
    public ICollection<Reservation> Reservations { get; set; } = [];
}
