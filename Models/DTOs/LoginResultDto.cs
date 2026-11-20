using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTOs
{
    public class LoginResultDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}
