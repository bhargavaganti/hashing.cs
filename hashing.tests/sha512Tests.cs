using hashing.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashing.tests
{
    [TestClass()]
    public class sha512Tests
    {
        [TestClass()]
        public class sha512asciiTests
        {
            [TestMethod()]
            [TestCategory("Sha512")]
            public void Sha512asciiEncodeTest()
            {
                /**
                 * php -r "echo hash('sha512', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
                 * ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1
                 */
                //string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";

                //sha512ascii sha = new sha512ascii();
                //string encoded = sha.encode(orignal);
                //string expect = "ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1";

                //Assert.AreEqual(expect, encoded);
                Assert.Fail();
            }
        }

        [TestMethod()]
        [TestCategory("Sha512")]
        public void Sha512Test()
        {
            /**
             * PHP: php -r "echo hash('sha512', 'A quick brown fox jumps over the lazy dog.');"
             * 
             * 3045575cf3b873dd656f5f3426e04a4acd11950bb2538772ee14867002b408e21ff18ef7f7b2cab484a3c1c0be3f8acc4aed536a427353c7748dc365fc1a8646
             */
            hasher h = new hasher();
            string hash = h.sha512("A quick brown fox jumps over the lazy dog.");
            string expect = @"0EW\�s�eo_4&�JJ���S�r��p������ʴ�����?��J�SjBsS�t��e��F";

            Assert.AreEqual(expect, hash);
            Assert.Fail();
        }

        [TestMethod()]
        [TestCategory("Sha512")]
        public void sha512asciiTest()
        {
            /**
             * PHP: php -r "echo hash('sha512', 'A quick brown fox jumps over the lazy dog.');"
             * 
             * 3045575cf3b873dd656f5f3426e04a4acd11950bb2538772ee14867002b408e21ff18ef7f7b2cab484a3c1c0be3f8acc4aed536a427353c7748dc365fc1a8646
             */
            hasher h = new hasher();
            string hash = h.sha512ascii("A quick brown fox jumps over the lazy dog.");
            string expect = "3045575cf3b873dd656f5f3426e04a4acd11950bb2538772ee14867002b408e21ff18ef7f7b2cab484a3c1c0be3f8acc4aed536a427353c7748dc365fc1a8646";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Sha512")]
        public void Sha512EncodeTest()
        {
            /**
             * PHP: php -r "echo hash('sha512', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1
             * 
             * PHP: php -r "echo hash('sha512/256', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * 9779d971e292b4550f30a66af8484c2fd0e666e0f67834030c0f211f06efec2b
             */
            //string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";

            //sha512 sha = new sha512();
            //string encoded = sha.encode(orignal);
            //string expect = "ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1";

            //// {"Assert.AreEqual failed. Expected:<ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1>. Actual:<�\u0004+(����MB�ۍ\f�\u0017\f�9\n�\u0018�B��\u0004�\u0011u\v�*\u000fז��:#>�\fZ\u007f�\b0cڹ*��\u0006G���WL�>. "}
            //Assert.AreEqual(expect, encoded);
            Assert.Fail();
        }
    }
}