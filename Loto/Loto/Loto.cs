using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, WinProbability(1, 1));
        }
        double WinProbability(int range, int drawingsNumber)
        {
            return 0;
        }
    }
}