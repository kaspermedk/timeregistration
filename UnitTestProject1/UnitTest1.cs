using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tidsregistrering;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc c = new Calc();
            int r = 2 + 2;
            Assert.AreEqual(c.add(2, 2), r);
            
        }
    }
}
