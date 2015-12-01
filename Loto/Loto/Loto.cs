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
        [TestMethod]
        public void TestProbability2from3()
        {
            Assert.AreEqual(0.33, WinProbability(3, 2),0.01);
        }
        [TestMethod]
        public void TestProbability6from49()
        {
            Assert.AreEqual(0.00000007151123842018516, WinProbability(49, 6), 0.00000001);
        }
        double WinProbability(double  range, double  drawingsNumber)
        {
            double probability = 1;
            for (int i = 0; i < drawingsNumber; i++)
            {
               probability = probability * (drawingsNumber-i) / (range-i);
            }
            return probability;
        }
    }
}