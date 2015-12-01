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
             double probability = drawingsNumber / range;
             return probability;
        }
    }
}