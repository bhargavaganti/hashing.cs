using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.tests
{
    [TestClass()]
    public class sha512asciiTests
    {
        [TestMethod()]
        public void sha512asciiEncodeTest()
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
        }
    }
}