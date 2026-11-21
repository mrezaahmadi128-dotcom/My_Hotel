using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities;

public class PhoneVerification
{
    public int Id { get; set; }
    public string MobileNumber{ get; set; }=string.Empty;
    public string CodeHash{ get; set; }= string.Empty;
    public DateTime CreatedAtUtc{ get; set; }
    public DateTime ExpiresAtUtc { get; set; }
    public int FailedAttempts{ get; set; }
    public bool IsUsed{ get; set; }

}
