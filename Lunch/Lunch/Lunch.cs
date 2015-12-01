using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, CalculateLowestCommonDenominator(1, 2));
        }
        int CalculateLowestCommonDenominator(int number1, int number2)
        {
            return 0;
        }
    }
}
