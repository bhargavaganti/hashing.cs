using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.classes
{
    /**
     * @see http://php.net/manual/en/faq.passwords.php#faq.passwords.fasthash
     */
    internal interface encoder
    {
        string encode(string text);
        string decode(string text);
    }
}
