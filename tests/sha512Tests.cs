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
    public class sha512Tests
    {
        [TestMethod()]
        public void Sha512EncodeTest()
        {
            /**
             * PHP: php -r "echo hash('sha512', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1
             * 
             * PHP: php -r "echo hash('sha512/256', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * 9779d971e292b4550f30a66af8484c2fd0e666e0f67834030c0f211f06efec2b
             */
            string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";

            sha512 sha = new sha512();
            string encoded = sha.encode(orignal);
            string expect = "ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1";

            // {"Assert.AreEqual failed. Expected:<ea042b28a2fbae914d42c5db8d0c8c170c9a390add18d042b4ec04b011750b922a0fd79690a13a233ece0c5a7fd3083063dab92afcc40647e18ee9b5de574cc1>. Actual:<�\u0004+(����MB�ۍ\f�\u0017\f�9\n�\u0018�B��\u0004�\u0011u\v�*\u000fז��:#>�\fZ\u007f�\b0cڹ*��\u0006G���WL�>. "}
            Assert.AreEqual(expect, encoded);
        }
    }
}