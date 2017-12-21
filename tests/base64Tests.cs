using Microsoft.VisualStudio.TestTools.UnitTesting;
using classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Tests
{
    [TestClass()]
    public class base64Tests
    {
        [TestMethod()]
        public void Base64DecodeTest()
        {
            /**
             * PHP: php -r "echo base64_encode('abc');"
             */
            //base64 bs = new base64();
            //string original = "abc";
            //string expected = "YWJj";

            //string encoded = bs.encode(original);
            //string decoded = bs.decode(encoded);

            //Assert.AreEqual(expected, encoded);
            //Assert.AreEqual(original, decoded);
            //Assert.AreNotEqual(original, encoded);
        }

        [TestMethod()]
        public void Base64DecodeTest2()
        {
            /**
             * PHP: php -r "echo base64_encode('test');"
             */
            //base64 bs = new base64();
            //string expect = "test";
            //string encoded = "dGVzdA==";

            //string decoded = bs.decode(encoded);

            //Assert.AreEqual(expect, decoded);
            //Assert.AreNotEqual(encoded, decoded);
        }
    }
}