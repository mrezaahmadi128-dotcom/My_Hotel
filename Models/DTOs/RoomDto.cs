using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTOs;

public class RoomDto
{
    public int Id { get;private set; }
    public int RoomNumber { get;private set; }
    public int Capacity { get;private set; }
    public decimal Price { get;private set; }
    public ICollection<ReservationDto> Reservations{ get; set; }
}
