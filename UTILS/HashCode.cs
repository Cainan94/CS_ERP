using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    public class HashCode
    {
        public static string GenerateHashValue(String Values)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(Values));

            StringBuilder hasValue = new StringBuilder(hashBytes.Length * 2);
            foreach(byte b in hashBytes)
            {
                hasValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }
            return hasValue.ToString();
        }
    }
}
