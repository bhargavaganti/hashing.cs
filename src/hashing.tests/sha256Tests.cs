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
    }
}