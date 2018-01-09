using Microsoft.VisualStudio.TestTools.UnitTesting;
using hashing.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// @see https://stackoverflow.com/questions/10168240/encrypting-decrypting-a-string-in-c-sharp
// @todo Can change passphrase manually
namespace hashing.classes.Tests
{
    [TestClass()]
    public class rinjdaelTests
    {
        [TestMethod()]
        public void rinjdael_decodeTest()
        {
            string orignal = "I am a test.";

            hasher h = new hasher();
            string cypher = h.rinjdael_encode(orignal);
            string decoded = h.rinjdael_decode(cypher);

            Assert.AreEqual(orignal, decoded);
            Assert.AreNotEqual(cypher, decoded);
        }

        [TestMethod()]
        public void rinjdael_decodeLongTextTest()
        {
            string password = "with open sesame password";

            // generates a very long text
            string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";
            for(int i=0; i<20; ++i)
            {
                orignal += string.Format("#{0}. {1}", i, orignal);
            }

            hasher h = new hasher();
            string cypher = h.rinjdael_encode(orignal, password);
            string decoded = h.rinjdael_decode(cypher, password);

            Assert.AreEqual(orignal, decoded);
            Assert.AreNotEqual(cypher, decoded);
        }

        [TestMethod()]
        public void rinjdael_modifiedPasswordCannotDecrypt()
        {
            string orignal = "I am a test.";
            string password = "locked out";

            hasher h = new hasher();
            string cypher = h.rinjdael_encode(orignal, password);

            // password is modified here
            string decoded1 = h.rinjdael_decode(cypher, password+" ");
            string decoded2 = h.rinjdael_decode(cypher, password);

            Assert.AreNotEqual(orignal, decoded1);
            Assert.AreEqual(orignal, decoded2);
        }
    }
}