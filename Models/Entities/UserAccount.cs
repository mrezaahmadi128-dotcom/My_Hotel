using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities;

public class UserAccount
{
    public UserAccount(
         string firstName
        ,string lastName
        ,string userName
        ,string passwordHash
        ,string mobileNumber)
    {
        FirstName= firstName;
        LastName=lastName;
        UserName = userName;
        PasswordHash= passwordHash;
        MobileNumber = mobileNumber;
    }
    public int Id { get;private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get;private set; } = string.Empty;
    public string UserName { get;private set; } = string.Empty;
    public string PasswordHash { get;private set; } = string.Empty;
    public string MobileNumber { get;private set; } = string.Empty;
}
