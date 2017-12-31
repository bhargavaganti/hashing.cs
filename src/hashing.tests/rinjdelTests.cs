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
    public class rinjdelTests
    {
        [TestMethod()]
        public void rinjdel_encodeTest()
        {
            // all times, cypher changes
            //string cypher_expected = "IFFE3PEx1S+v7n27B1ZNXqK81W47xgpjda9X7F4B21dXwvl02R3QOZalfSqkYDvuP5rarmna4WuGd7NV9KgKpbGXHOT4ABkvBd+eOXdw55DCdwK2t+DkQ9Wfr+XrHhsf";
            //Assert.AreEqual(cypher_expected, cypher);
            
            // no need to implement
            Assert.Fail();
        }

        [TestMethod()]
        public void rinjdel_decodeTest()
        {
            string orignal = "I am a test.";

            hasher h = new hasher();
            string cypher = h.rinjdel_encode(orignal);
            string decoded = h.rinjdel_decode(cypher);

            Assert.AreEqual(orignal, decoded);
            Assert.AreNotEqual(cypher, decoded);
        }

        [TestMethod()]
        public void rinjdel_decodeLongTextTest()
        {
            string password = "with open sesame password";

            // generates a very long text
            string orignal = "A Quick Brown Fox Jumps Over The Lazy Dog.";
            for(int i=0; i<20; ++i)
            {
                orignal += string.Format("#{0}. {1}", i, orignal);
            }

            hasher h = new hasher();
            string cypher = h.rinjdel_encode(orignal, password);
            string decoded = h.rinjdel_decode(cypher, password);

            Assert.AreEqual(orignal, decoded);
            Assert.AreNotEqual(cypher, decoded);
        }

        [TestMethod()]
        public void rinjdel_modifiedPasswordCannotDecrypt()
        {
            string orignal = "I am a test.";
            string password = "locked";

            hasher h = new hasher();
            string cypher = h.rinjdel_encode(orignal, password);
            string decoded = h.rinjdel_decode(cypher, password+" "); // password modified

            Assert.AreNotEqual(orignal, decoded);
        }
    }
}