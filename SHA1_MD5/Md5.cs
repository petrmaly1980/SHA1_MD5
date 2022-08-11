using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHA1_MD5
{
    internal class Md5
    {
        /// <summary>
        /// Using  GetMD5Ascii(input, "ASCII");
        /// No Replaced "-".
        /// </summary>
        public string GetMD5Ascii(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output;
        }
        /// <summary>
        /// Using  GetMD5AsciiReplaced(input, "ASCII");
        /// Replaced "-" to empty.
        /// </summary>
        public string GetMD5AsciiReplaced(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output.ToLower().Replace("-", String.Empty);
        }
        /// <summary>
        /// Using  GetMD5Unicode(input, "ASCII");
        /// Replaced "-" to empty.
        /// </summary>
        public string GetMD5Unicode(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.Unicode.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output;
        }
        /// <summary>
        /// Using  GetMD5UnicodeReplaced(input, "ASCII");
        /// Replaced "-" to empty.
        /// </summary>
        public string GetMD5UnicodeReplaced(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.Unicode.GetBytes(input));
            string output = BitConverter.ToString(bytes);
            return output.ToLower().Replace("-", String.Empty);
        }
    }
}
