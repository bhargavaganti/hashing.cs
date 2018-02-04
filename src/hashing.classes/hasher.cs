using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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

        /**
         * Generating random string multiple times should not result same.
         */
        public string random()
        {
            int length = 20;

            Random random = this.randomizer();
            string chars = this.randomCharacters();
            string r = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            return r;
        }

        private string randomCharacters()
        {
            Random random = this.randomizer();

            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            //chars = Enumerable.Range(0, chars.Length).OrderBy(ri => random.Next()).ToArray().ToString();
            int offset = 1 + 5;
            int c = random.Next(0, chars.Length); // - offset);
            string first = chars.Substring(0, c);
            string second = chars.Substring(c, chars.Length - c);
            chars = string.Format("{0}{1}", second, first);
            return chars;
        }

        private Random randomizer()
        {
            //Random random = new Random(Guid.NewGuid().GetHashCode());
            Random random = new Random(new System.DateTime().Millisecond);
            return random;
        }

        /**
         * Generating random string multiple times should not result same.
         *
         * @see https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings-in-c
         */
        public string r()
        {
            int maxSize = 20;

            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider(Guid.NewGuid().ToString()))
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
    }
}
 