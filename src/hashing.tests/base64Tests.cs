using hashing.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashing.tests
{
    [TestClass()]
    public class base64Tests
    {
        [TestMethod()]
        [TestCategory("Base64")]
        public void Base64EncodeTest()
        {
            /**
             * SQL: SELECT TO_BASE64("A quick brown fox jumps over the lazy dog.");
             * PHP: php -r "echo base64_encode('A quick brown fox jumps over the lazy dog.');"
             * 
             * QSBxdWljayBicm93biBmb3gganVtcHMgb3ZlciB0aGUgbGF6eSBkb2cu
             */
            hasher h = new hasher();
            string hash = h.base64_encode("A quick brown fox jumps over the lazy dog.");
            string expect = "QSBxdWljayBicm93biBmb3gganVtcHMgb3ZlciB0aGUgbGF6eSBkb2cu";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Base64")]
        public void Base64DecodeTest()
        {
            /**
             * SQL: SELECT FROM_BASE64("QSBxdWljayBicm93biBmb3gganVtcHMgb3ZlciB0aGUgbGF6eSBkb2cu");
             * PHP: php -r "echo base64_decode('QSBxdWljayBicm93biBmb3gganVtcHMgb3ZlciB0aGUgbGF6eSBkb2cu');"
             * 
             * A quick brown fox jumps over the lazy dog.
             */
            hasher h = new hasher();
            string original = h.base64_decode("QSBxdWljayBicm93biBmb3gganVtcHMgb3ZlciB0aGUgbGF6eSBkb2cu");
            string expect = "A quick brown fox jumps over the lazy dog.";

            Assert.AreEqual(expect, original);
        }
    }
}