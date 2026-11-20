
using System;
using Models.Entities;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities;

public class Guest
{
    public Guest(
     string firstName
    , string lastName
    , string nationalCode
    , string mobileNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalCode = nationalCode;
        MobileNumber = mobileNumber;
    }
    public int Id { get;  set; }
    public string FirstName { get;  set; } = string.Empty;
    public string LastName { get;  set; } = string.Empty;
    public string NationalCode { get;  set; } = string.Empty;
    public string MobileNumber { get; set; }= string.Empty;
    public ICollection<Reservation> Reservations { get; set; } = [];
}
