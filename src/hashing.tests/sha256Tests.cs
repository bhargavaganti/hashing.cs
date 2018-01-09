using hashing.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashing.tests
{
    /**
     * @see https://docs.microsoft.com/en-us/sql/t-sql/functions/hashbytes-transact-sql
     */
    [TestClass()]
    public class sha256Tests
    {
        [TestMethod()]
        [TestCategory("Sha256")]
        public void Sha256Test()
        {
            hasher h = new hasher();
            string hash = h.sha256("A quick brown fox jumps over the lazy dog.");
            string expect = "��%��ԄnL�u�\u0003��\u000f�Vj���W\u0014X��P��";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Sha256")]
        public void Sha256AsciiTest()
        {
            /**
             * PHP: php -r "echo hash('sha256', 'A quick brown fox jumps over the lazy dog.');"
             * SQL: SELECT SHA2('A quick brown fox jumps over the lazy dog.', 256);
             * 
             * ffca2587cfd4846e4cb975b503c9eb940f94566aa394e8bd571458b9da5097d5
             */
            hasher h = new hasher();
            string hash = h.sha256ascii("A quick brown fox jumps over the lazy dog.");
            string expect = "ffca2587cfd4846e4cb975b503c9eb940f94566aa394e8bd571458b9da5097d5";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Sha256"), TestCategory("Failing")]
        public void ShaUnicdoeTest()
        {
            /**
             * @see https://dev.mysql.com/doc/refman/5.7/en/encryption-functions.html#function_sha2
             * @see https://dev.mysql.com/doc/refman/8.0/en/encryption-functions.html
             * 
             * SQL: SELECT SHA2('क का कि की कु कू के कै को कौ', 512);
             * SQL: SELECT SHA2('क का कि की कु कू के कै को कौ', 256);
             * SQL: SELECT SHA1('क का कि की कु कू के कै को कौ');
             * 
             * 31998db2c979957bd4930d08413b5bcebd0b2607f1bc9eefdd76db98dd63b3a3d6b513875b2d954053a60a0d626dab205c0a2e860e3ce090a3071db4a2c352da
             */
            string original = "क का कि की कु कू के कै को कौ";

            hasher h = new hasher();
            string hash = h.sha512ascii(original);
            string expect = "3534e6cb0c8f2760709528c7713055122c340361";

            Assert.AreEqual(expect, hash);
        }
    }
}