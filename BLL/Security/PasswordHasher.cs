using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace BLL.Security;

    public class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations= 600_000;

        private const string Algorithm = "PBKDF2-SHA256";
        public string HashPassword(string password)
        {
            byte[] salt =RandomNumberGenerator.GetBytes(SaltSize) ;
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                HashSize);
            return $"{Algorithm}${Iterations}$" +
                   $"{Convert.ToBase64String(salt)}$" +
                   $"{Convert.ToBase64String(hash)}";
        }
        public bool VerifyPassword(string password,string storedHash)
        {
            if(string.IsNullOrEmpty(password) ||
               string.IsNullOrWhiteSpace(storedHash))
            {
                return false;
            }
            string[] parts = storedHash.Split('$');
      
            if(parts.Length !=4  || parts[0]!=Algorithm)
                return false;
            if(!int.TryParse(parts[1], out int iterations))
                return false;
            if(iterations<100_000 || iterations>2_000_000)
                return false;
            try
            {
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] originalHash = Convert.FromBase64String(parts[3]);
                if(salt.Length!= SaltSize || originalHash.Length!= HashSize)
                return false;
                byte[] newhash = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256,
                    HashSize
                    );
                return CryptographicOperations.FixedTimeEquals(
                    originalHash, 
                    newhash);
            }
            catch (FormatException)
            {
                return false;
            }

        }
}
