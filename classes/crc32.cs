using classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class crc32a : encoder
    {
        /**
         * @see https://damieng.com/blog/2006/08/08/Calculating_CRC32_in_C_and_NET
         * @see https://github.com/damieng/DamienGKit/blob/master/CSharp/DamienG.Library/Security/Cryptography/Crc32.cs
         */
        public string encode(string text)
        {
            //Crc32 crc32 = new Crc32();
            //String hash = String.Empty;

            //using (FileStream fs = File.Open("c:\\myfile.txt", FileMode.Open))
            //    foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

            //string output = Encoding.UTF8.GetString(hash);
            //return output;

            return "";
        }

        public string decode(string text)
        {
            throw new NotImplementedException();
        }
    }
}
