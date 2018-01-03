using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.classes
{
    public partial class hasher
    {
        public string sha256(string text)
        {
            sha256 h = new sha256();
            string hash = h.encode(text);

            return hash;
        }

        public string sha256ascii(string text)
        {
            sha256ascii h = new sha256ascii();
            string hash = h.encode(text);

            return hash;
        }

        public string sha512(string text)
        {
            sha512 h = new sha512();
            string hash = h.encode(text);

            return hash;
        }

        public string sha512ascii(string text)
        {
            sha512ascii h = new sha512ascii();
            string hash = h.encode(text);

            return hash;
        }
    }
}
