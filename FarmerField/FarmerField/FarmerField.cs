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
        double initialSquareFinder(int aditionalLength, int totalArea)
        {
            double  Delta = aditionalLength * aditionalLength + 4 * totalArea;
            double x1 = (-aditionalLength + Math.Sqrt(Delta)) / 2;
            double x2 = (-aditionalLength - Math.Sqrt(Delta)) / 2;
           Console.Write(x1);
            if (x1 > 0)
                return x1;
            else
                return x2;
        }
    }
}
//D=b^2-4ac
//x1=-b+RD/2a
//b=aditionalLength
//a=1
//c=totalArea
