using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHA1_MD5
{
    internal class Sha1
    {
        /// <summary>
        /// Using  GetSHA1ASCII(input, "ASCII");
        /// </summary>
        public string GetSHA1ASCII(string input)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes = sha1.ComputeHash(Encoding.ASCII.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output;
        }
        /// <summary>
        /// Using  GetSHA1Unicode(input, "Unicode");
        /// </summary>
        public string GetSHA1Unicode(string input)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output;
        }
        /// <summary>
        /// Using  GetSHA1ReplaceASCII(input, "ASCII");
        /// </summary>
        public string GetSHA1ReplaceASCII(string input)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes = sha1.ComputeHash(Encoding.ASCII.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output.ToLower().Replace("-", String.Empty);
        }
        /// <summary>
        /// Using  GetSHA1ReplaceUnicode(input, "ASCII");
        /// </summary>
        public string GetSHA1ReplaceUnicode(string input)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output.ToLower().Replace("-", String.Empty);
        }
    }
}
