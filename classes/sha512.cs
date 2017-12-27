using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/**
 * @see https://msdn.microsoft.com/en-us/library/s02tk69a(v=vs.110).aspx
 * @see https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha512managed(v=vs.110).aspx
 * 
 * @see https://docs.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
 */
namespace hashing.classes
{
    internal class sha512 : encoder
    {
        public string encode(string text)
        {
            SHA512 sha = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            byte[] hash = sha.ComputeHash(bytes);

            string output = Encoding.UTF8.GetString(hash);
            return output;
        }

        public string decode(string text)
        {
            throw new NotImplementedException();
        }
    }
}
