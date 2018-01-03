using hashing.classes.engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.classes
{
    public partial class hasher
    {
        public string des_encode(string text)
        {
            des h = new des();
            string encryptedstring = h.encode(text);

            return encryptedstring;
        }

        public string des_decode(string text)
        {
            des h = new des();
            string decryptedstring = h.decode(text);

            return decryptedstring;
        }
    }
}
