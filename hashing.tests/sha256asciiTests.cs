using hashing.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hashing.tests
{
    [TestClass()]
    public class Sha256asciiTests
    {
        [TestMethod()]
        public void Sha256asciiEncodeTest()
        {
            string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";

            sha256ascii sha = new sha256ascii();
            string encoded = sha.encode(orignal);
            string expect = "a0b301f8b219bd504f52c116289f1285a3dcf2d30ff89753e40a7e6f94e61990";

            Assert.AreEqual(expect, encoded);
        }
    }
}