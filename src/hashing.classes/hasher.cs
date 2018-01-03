using System;

namespace hashing.classes
{
    /**
     * List of hashing algorithms available in PHP
     * PHP: php -r "print_r(hash_algos());"
     */
    public partial class hasher
    {
        public string md5(string text)
        {
            md5 h = new md5();
            string hash = h.encode(text);

            return hash;
        }

        public string crc32(string text)
        {
            crc32 h = new crc32();
            string hash = h.encode(text);

            return hash;
        }
    }
}
