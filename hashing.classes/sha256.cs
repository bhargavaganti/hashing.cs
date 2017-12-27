using System;
using System.Security.Cryptography;
using System.Text;

/**
 * @see https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha256(v=vs.110).aspx
 * @see https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha256managed(v=vs.110).aspx
 * @see http://www.faqs.org/rfcs/rfc3174.html
 * @see https://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256
 */
namespace hashing.classes
{
    internal class sha256 : encoder
    {
        public string encode(string text)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            byte[] hash = mySHA256.ComputeHash(bytes);

            string output = Encoding.UTF8.GetString(hash);
            return output;
        }

        public string decode(string text)
        {
            throw new NotImplementedException();
        }
    }
}
