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
            Assert.AreEqual(2, CalculateLowestCommonMultiple(1, 2));
        }
        [TestMethod]
        public void Test4and6()
        {
            Assert.AreEqual(12, CalculateLowestCommonMultiple(4, 6));
        }
        [TestMethod]
        public void Test20and30()
        {
            Assert.AreEqual(60, CalculateLowestCommonMultiple(20, 30));
        }
        int CalculateLowestCommonMultiple(int number1, int number2)
        {
            for (int i = 1;; i++)
            {
                if (i%number1==0 && i%number2 == 0)
                {
                    return  i;
                }

            }
        }
    }
}
