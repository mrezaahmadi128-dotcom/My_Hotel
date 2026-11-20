using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Security
{
    public static class OtpGenerator
    {
        public static string GenerateCode()
        {
            int code = RandomNumberGenerator.GetInt32(1000, 10000);
            return code.ToString();
        }
    }
}
