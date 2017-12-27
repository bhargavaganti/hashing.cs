using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/**
 * @see https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx
 * @see http://md5decoder.org/
 * @see http://hash.urih.com/example/
 */
namespace hashing.classes
{
    internal class md5 : encoder
    {
        public string encode(string text)
        {
            // Convert the input string to a byte array and compute the hash.
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

            //string output = Encoding.UTF8.GetString(data);
            //return output;

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public string decode(string text)
        {
            throw new NotImplementedException();
        }
    }
}
