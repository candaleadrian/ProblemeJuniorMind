using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void TestProbability1()
        {
            Assert.AreEqual(1, WinProbability(1, 1));
        }
        [TestMethod]
        public void TestProbability0p5()
        {
            Assert.AreEqual(0.5, WinProbability(2, 1));
        }
        double WinProbability(double  range, double  drawingsNumber)
        {
            double  FactorialRange = 1;
            for (int i = 1; i < range+1; i++)
            {
                FactorialRange = FactorialRange * i; 
            }
            double probability = drawingsNumber / FactorialRange;
            return probability;
        }
    }
}