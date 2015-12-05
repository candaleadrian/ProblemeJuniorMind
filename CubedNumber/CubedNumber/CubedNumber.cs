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
        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(1192, CalcuateCubedNumber(5));
        }
        decimal CalcuateCubedNumber(int number)
        {
            int counter = 0;
            for (int i = 1;; i++)
            {
                if (i*i*i % 1000 == 888)
                {
                    counter++;
                    if (counter == number)
                    {
                        return i;
                    }
                }
            }            
        }
    }
}
