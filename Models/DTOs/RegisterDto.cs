using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTOs;

public class RegisterDto
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword { get; set; }

    public string MobileNumber { get; set; }
}
