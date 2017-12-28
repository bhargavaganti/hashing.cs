using hashing.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashing.tests
{
    [TestClass()]
    public class sha512Tests
    {
        [TestMethod()]
        [TestCategory("Sha512")]
        public void Sha512Test()
        {
            hasher h = new hasher();
            string hash = h.sha512("A quick brown fox jumps over the lazy dog.");
            string expect = @"0EW\�s�eo_4&�JJ���S�r��p������ʴ�����?��J�SjBsS�t��e��F";

            Assert.AreEqual(expect, hash);
        }

        [TestMethod()]
        [TestCategory("Sha512")]
        public void Sha512AsciiTest()
        {
            /**
             * PHP: php -r "echo hash('sha512', 'A quick brown fox jumps over the lazy dog.');"
             * SQL: SELECT SHA2('A quick brown fox jumps over the lazy dog.', 512);
             * 
             * DECLARE @HashThis NVARCHAR(4000);
             * SET @HashThis = CONVERT(NVARCHAR(4000), 'A quick brown fox jumps over the lazy dog.');
             * SELECT HASHBYTES('SHA1', @HashThis);
             * 
             * @see https://dev.mysql.com/doc/refman/5.5/en/encryption-functions.html
             * @see https://docs.microsoft.com/en-us/sql/t-sql/functions/hashbytes-transact-sql
             * 
             * 3045575cf3b873dd656f5f3426e04a4acd11950bb2538772ee14867002b408e21ff18ef7f7b2cab484a3c1c0be3f8acc4aed536a427353c7748dc365fc1a8646
             */
            hasher h = new hasher();
            string hash = h.sha512ascii("A quick brown fox jumps over the lazy dog.");
            string expect = "3045575cf3b873dd656f5f3426e04a4acd11950bb2538772ee14867002b408e21ff18ef7f7b2cab484a3c1c0be3f8acc4aed536a427353c7748dc365fc1a8646";

            Assert.AreEqual(expect, hash);
        }
    }
}