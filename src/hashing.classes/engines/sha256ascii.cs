﻿using System;
using System.Security.Cryptography;
using System.Text;

/**
 * @see https://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256
 */
namespace hashing.classes
{
    internal class sha256ascii : encoder
    {
        public string encode(string text)
        {
            SHA256Managed crypt = new SHA256Managed();

            string hash = string.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetByteCount(text));
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
