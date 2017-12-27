using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.tests
{
    [TestClass()]
    public class md5Tests
    {
        [TestMethod()]
        public void MD5EncodeTest()
        {
            //string orignal = "";

            //md5 md5 = new md5();
            //string encoded = md5.encode(orignal);
            //string expect = "d41d8cd98f00b204e9800998ecf8427e";

            //Assert.AreEqual(expect, encoded);
        }

        [TestMethod()]
        public void MD5EncodeTest2()
        {
            /**
             * SQL: SELECT MD5("A Quick Brown Fox Jumps Over The Lazy Dog.");
             * PHP: echo md5("A Quick Brown Fox Jumps Over The Lazy Dog.");
             * PHP: php -r "echo md5('A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * PHP: php -r "echo hash('md5', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * C#
             */
            //string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";

            //md5 md5 = new md5();
            //string encoded = md5.encode(orignal);
            //string expect = "1e10b5a2e4f551bfb8ab46c5c998a998";

            //Assert.AreEqual(expect, encoded);
        }
    }
}