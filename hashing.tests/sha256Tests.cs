using hashing.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashing.tests
{
    [TestClass()]
    public class sha256Tests
    {
        [TestMethod()]
        [TestCategory("Sha256")]
        public void Sha256asciiEncodeTest()
        {
            string original = "A Quick Brown Fox Jumps Over The Lazy Dog.";

            hasher h = new hasher();

            string encoded = h.sha256(original);
            string expect = "a0b301f8b219bd504f52c116289f1285a3dcf2d30ff89753e40a7e6f94e61990";

            Assert.AreEqual(expect, encoded);
        }

        [TestMethod()]
        [TestCategory("Sha256")]
        public void sha256Test()
        {
            hasher h = new hasher();
            string hash = h.sha256("A quick brown fox jumps over the lazy dog.");
            string expect = "��%��ԄnL�u�\u0003��\u000f�Vj���W\u0014X��P��";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Sha256")]
        public void sha256asciiTest()
        {
            /**
             * PHP: php -r "echo hash('sha256', 'A quick brown fox jumps over the lazy dog.');"
             * 
             * ffca2587cfd4846e4cb975b503c9eb940f94566aa394e8bd571458b9da5097d5
             */
            hasher h = new hasher();
            string hash = h.sha256ascii("A quick brown fox jumps over the lazy dog.");
            string expect = "ffca2587cfd4846e4cb975b503c9eb940f94566aa394e8bd571458b9da5097d5";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Sha256")]
        public void Sha256EncodeTest()
        {
            /**
             * php -r "print_r(hash_algos());"
             * 
             * SQL: SELECT SHA1("A Quick Brown Fox Jumps Over The Lazy Dog.");
             * php -r "echo sha1('A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * PHP: php -r "echo hash('sha1', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * 
             * 3f073d5e6b4448046bad39081ba04c7f8a37500d
             * 
             * PHP: php -r "echo hash('ripemd160', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * 1b545d3e29d84a5e0748f3025448778b96fc6779
             */
            //string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";

            //sha256 sha = new sha256();
            //string encoded = sha.encode(orignal);
            ////string expect = "3f073d5e6b4448046bad39081ba04c7f8a37500d"; // PHP's SHA1
            //string expect = "a0b301f8b219bd504f52c116289f1285a3dcf2d30ff89753e40a7e6f94e61990";

            //Assert.AreEqual(expect, encoded);
            Assert.Fail();
        }
    }
}