using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubedNumber
{
    [TestClass]
    public class CubedNumber
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(192, CalcuateCubedNumber(1));
        }
        decimal CalcuateCubedNumber(decimal number)
        {
            return 0;
        }
    }
}
