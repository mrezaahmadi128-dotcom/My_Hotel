using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTOs;

public class ReservationDto
{
    public int Id { get;private set; }
    public int RoomId { get;private set; }
    public RoomDto Room { get; private set; }
    public int GuestId { get;private set; }
    public GuestDto Guest { get; private set; }
    public DateTime DateIn { get;private set; }
    public DateTime DateOut { get;private set; }


}
