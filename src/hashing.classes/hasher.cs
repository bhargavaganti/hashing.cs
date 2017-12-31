using System;

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

        public string rinjdel_encode(string text)
        {
            /**
             * Default key when password is NOT supplied
             * To be same as as other part
             */
            string password = "something extremely secret";

            //rinjdel h = new rinjdel(password);
            //string encryptedstring = h.encode(text);
            string encryptedstring = this.rinjdel_encode(text, password);

            return encryptedstring;
        }

        public string rinjdel_decode(string text)
        {
            /**
             * Default key when password is NOT supplied
             * To be same as as other part
             */
            string password = "something extremely secret";

            //rinjdel h = new rinjdel(password);
            //string decryptedstring = h.decode(text);
            string decryptedstring = this.rinjdel_decode(text, password);

            return decryptedstring;
        }

        public string rinjdel_encode(string orignal, string password)
        {
            string salt = "1f Mi55in6 p@$$vv0rd";
            rinjdel h = new rinjdel(password+salt);
            string encryptedstring = h.encode(orignal);

            return encryptedstring;
        }

        public string rinjdel_decode(string cypher, string password)
        {
            string salt = "1f Mi55in6 p@$$vv0rd";
            rinjdel h = new rinjdel(password+salt);
            string decryptedstring = h.decode(cypher);

            return decryptedstring;
        }
    }
}
