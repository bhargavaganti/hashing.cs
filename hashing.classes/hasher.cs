namespace hashing.classes
{
    /**
     * List of hashing algorithms:
     * PHP: php -r "print_r(hash_algos());"
     */
    public class hasher
    {
        public string md5(string text)
        {
            md5 h = new md5();
            string hash = h.encode(text);

            return hash;
        }

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

        public string crc32(string text)
        {
            crc32 h = new crc32();
            string hash = h.encode(text);

            return hash;
        }
    }
}
