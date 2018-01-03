using Microsoft.VisualStudio.TestTools.UnitTesting;
using hashing.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.classes.Tests
{
    [TestClass()]
    public class desTests
    {

        [TestMethod()]
        public void des_decode()
        {
            string orignal = "I am a test.";
            for (int i = 0; i < 20; ++i)
            {
                orignal += string.Format("#{0}. {1}", i, orignal);
            }

            hasher h = new hasher();
            string cypher = h.des_encode(orignal);
            string decoded = h.des_decode(cypher);

            Assert.AreEqual(orignal, decoded);
            Assert.AreNotEqual(cypher, decoded);
        }
    }
}