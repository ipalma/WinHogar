using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.Utils
{
    public class EncryptionMethods
    {
        public string SHA256_Hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(password))
                  .Select(item => item.ToString("x2")));
            }
        }
        
    }
}
