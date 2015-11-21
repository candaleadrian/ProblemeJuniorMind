using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerField
{
    [TestClass]
    public class FarmerField
    {
        [TestMethod]
        public void LaturaPatratuluiTest1()
        {
            Assert.AreEqual(1,initialSquareFinder(1,2));
        }
        [TestMethod]
        public void LaturaPatratuluiTest2()
        {
            Assert.AreEqual(70, initialSquareFinder(10, 5600));
        }
        [TestMethod]
        public void TestDateProblema()
        {
            Assert.AreEqual(770, initialSquareFinder(230, 770000));
        }
        double initialSquareFinder(int aditionalLength, int totalArea)
        {
            double  sqrtDelta = Math.Sqrt(aditionalLength * aditionalLength + 4 * totalArea);
            double x1 = (-aditionalLength + sqrtDelta ) / 2;
            double x2 = (-aditionalLength - sqrtDelta) / 2;
            return x1 > 0?x1:x2;
        }
    }
}