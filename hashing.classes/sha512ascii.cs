using System;
using System.Security.Cryptography;
using System.Text;

namespace hashing.classes
{
    internal class sha512ascii : encoder
    {
        public string encode(string text)
        {
            SHA512 sha = SHA512Managed.Create();

            string hash = string.Empty;
            byte[] crypto = sha.ComputeHash(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetByteCount(text));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }

            return hash;
        }

        public string decode(string text)
        {
            throw new NotImplementedException();
        }
    }
}
