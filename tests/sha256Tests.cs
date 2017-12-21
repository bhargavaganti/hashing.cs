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
    public class sha256Tests
    {
        [TestMethod()]
        public void Sha256EncodeTest()
        {
            /**
             * php -r "print_r(hash_algos());"
             * 
             * php -r "echo sha1('A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * 3f073d5e6b4448046bad39081ba04c7f8a37500d
             * 
             * PHP: php -r "echo hash('sha1', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * 3f073d5e6b4448046bad39081ba04c7f8a37500d
             * 
             * PHP: php -r "echo hash('ripemd160', 'A Quick Brown Fox Jumps Over The Lazy Dog.');"
             * 1b545d3e29d84a5e0748f3025448778b96fc6779
             */
            //string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";

            //sha256 sha = new sha256();
            //string encoded = sha.encode(orignal);
            ////string expect = "3f073d5e6b4448046bad39081ba04c7f8a37500d"; // PHP's SHA1
            //string expect = "a0b301f8b219bd504f52c116289f1285a3dcf2d30ff89753e40a7e6f94e61990";

            //Assert.AreEqual(expect, encoded);
        }
    }
}