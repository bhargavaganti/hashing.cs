using hashing.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashing.tests
{
    [TestClass()]
    public class md5Tests
    {
        [TestMethod()]
        [TestCategory("MD5")]
        public void md5Test()
        {
            /**
             * SQL: SELECT MD5("A quick brown fox jumps over the lazy dog.");
             * PHP: php -r "echo md5('A quick brown fox jumps over the lazy dog.');"
             * PHP: php -r "echo hash('md5', 'A quick brown fox jumps over the lazy dog.');"
             * 
             * df756a3769fcab0a261880957590c768
             */
            hasher h = new hasher();
            string hash = h.md5("A quick brown fox jumps over the lazy dog.");
            string expect = "df756a3769fcab0a261880957590c768";

            Assert.AreEqual(expect, hash);
        }
    }
}