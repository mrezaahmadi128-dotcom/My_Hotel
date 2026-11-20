using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTOs;

public class GuestDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get;  set; }
    public string NationalCode { get;  set; }
    public string MobileNumber { get;  set; }
    public ICollection<ReservationDto> Reservations { get;  set; }
}
