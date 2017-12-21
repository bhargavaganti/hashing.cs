using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @see https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
 * @see https://www.base64decode.org/
 */
namespace classes
{
    internal class base64 : encoder
    {
        public string encode(string text)
        {
            string output = "";

            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                output = Convert.ToBase64String(bytes).ToString();
            }
            catch(Exception)
            {

            }

            return output;
        }

        public string decode(string text)
        {
            string otuput = "";
            try
            {
                byte[] bytes = Convert.FromBase64String(text);
                otuput = Encoding.UTF8.GetString(bytes);
            }
            catch(Exception)
            {

            }

            return otuput;
        }
    }
}
