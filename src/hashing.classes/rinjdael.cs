using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.classes
{
    public partial class hasher
    {
        public string rinjdael_encode(string text)
        {
            /**
             * Default key when password is NOT supplied
             * To be same as as other part
             */
            string password = "something extremely secret";

            //rinjdel h = new rinjdel(password);
            //string encryptedstring = h.encode(text);
            string encryptedstring = this.rinjdael_encode(text, password);

            return encryptedstring;
        }

        public string rinjdael_decode(string text)
        {
            /**
             * Default key when password is NOT supplied
             * To be same as as other part
             */
            string password = "something extremely secret";

            //rinjdel h = new rinjdel(password);
            //string decryptedstring = h.decode(text);
            string decryptedstring = this.rinjdael_decode(text, password);

            return decryptedstring;
        }

        public string rinjdael_encode(string orignal, string password)
        {
            string salt = "1f Mi55in6 p@$$vv0rd";
            rinjdael h = new rinjdael(password + salt);

            string encryptedstring;
            try
            {
                encryptedstring = h.encode(orignal);
            }
            catch (Exception)
            {
                encryptedstring = "Encoding error";
            }

            return encryptedstring;
        }

        public string rinjdael_decode(string cypher, string password)
        {
            string salt = "1f Mi55in6 p@$$vv0rd";
            rinjdael h = new rinjdael(password + salt);

            string decryptedstring;
            try
            {
                decryptedstring = h.decode(cypher);
            }
            catch (Exception)
            {
                decryptedstring = "Decoding error";
            }

            return decryptedstring;
        }
    }
}
