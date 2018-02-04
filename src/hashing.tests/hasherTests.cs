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
    public class hasherTests
    {
        [TestMethod()]
        public void randomTest()
        {
            hasher h = new hasher();

            string r1 = h.random();
            string r2 = h.random();

            Assert.AreNotEqual(r1, r2);
        }

        [TestMethod()]
        public void rTest()
        {
            hasher h = new hasher();

            string r1 = h.r();
            string r2 = h.r();

            Assert.AreNotEqual(r1, r2);
        }
    }
}