using Microsoft.VisualStudio.TestTools.UnitTesting;
using classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * php -r "print_r(hash_algos());"
 */
namespace classes.Tests
{
    [TestClass()]
    public class hasingTests
    {
        [TestMethod()]
        [TestCategory("Hasher")]
        public void md5Test()
        {
            /**
             * PHP: php -r "echo md5('A quick brown fox jumps over the lazy dog.');"
             * PHP: php -r "echo hash('md5', 'A quick brown fox jumps over the lazy dog.');"
             * 
             * df756a3769fcab0a261880957590c768
             */
            hasing h = new hasing();
            string hash = h.md5("A quick brown fox jumps over the lazy dog.");
            string expect = "df756a3769fcab0a261880957590c768";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Hasher")]
        public void sha256Test()
        {
            hasing h = new hasing();
            string hash = h.sha256("A quick brown fox jumps over the lazy dog.");
            string expect = "��%��ԄnL�u�\u0003��\u000f�Vj���W\u0014X��P��";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Hasher")]
        public void sha256asciiTest()
        {
            /**
             * PHP: php -r "echo hash('sha256', 'A quick brown fox jumps over the lazy dog.');"
             * 
             * ffca2587cfd4846e4cb975b503c9eb940f94566aa394e8bd571458b9da5097d5
             */
            hasing h = new hasing();
            string hash = h.sha256ascii("A quick brown fox jumps over the lazy dog.");
            string expect = "ffca2587cfd4846e4cb975b503c9eb940f94566aa394e8bd571458b9da5097d5";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Hasher")]
        public void sha512Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        [TestCategory("Hasher")]
        public void sha512asciiTest()
        {
            /**
             * PHP: php -r "echo hash('sha512', 'A quick brown fox jumps over the lazy dog.');"
             * 
             * 3045575cf3b873dd656f5f3426e04a4acd11950bb2538772ee14867002b408e21ff18ef7f7b2cab484a3c1c0be3f8acc4aed536a427353c7748dc365fc1a8646
             */
            hasing h = new hasing();
            string hash = h.sha512ascii("A quick brown fox jumps over the lazy dog.");
            string expect = "3045575cf3b873dd656f5f3426e04a4acd11950bb2538772ee14867002b408e21ff18ef7f7b2cab484a3c1c0be3f8acc4aed536a427353c7748dc365fc1a8646";

            Assert.AreEqual(expect, hash);
        }
    }
}