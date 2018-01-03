using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.classes
{
    public partial class hasher
    {
        public string base64_encode(string text)
        {
            base64 h = new base64();
            string hash = h.encode(text);

            return hash;
        }

        public string base64_decode(string text)
        {
            base64 h = new base64();
            string hash = h.decode(text);

            return hash;
        }
    }
}
