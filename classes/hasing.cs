using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class hasing
    {
        public string md5(string text)
        {
            md5 hasher = new md5();
            string hash = hasher.encode(text);

            return hash;
        }

        public string sha256(string text)
        {
            sha256 hasher = new sha256();
            string hash = hasher.encode(text);

            return hash;
        }

        public string sha256ascii(string text)
        {
            sha256ascii hasher = new sha256ascii();
            string hash = hasher.encode(text);

            return hash;
        }

        public string sha512(string text)
        {
            sha512 hasher = new sha512();
            string hash = hasher.encode(text);

            return hash;
        }

        public string sha512ascii(string text)
        {
            sha512ascii hasher = new sha512ascii();
            string hash = hasher.encode(text);

            return hash;
        }

        public string base64_encode(string text)
        {
            base64 hasher = new base64();
            string hash = hasher.encode(text);

            return hash;
        }

        public string base64_decode(string text)
        {
            base64 hasher = new base64();
            string hash = hasher.decode(text);

            return hash;
        }
    }
}
