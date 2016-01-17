using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class Fibonacci
    {
        [TestMethod]
        public void ShouldReturnFibonacciSumForZero()
        {
            Assert.AreEqual(0,CalculateFibonacci(0));
        }
        [TestMethod]
        public void ShouldReturnFibonacciSumForOne()
        {
            Assert.AreEqual(1, CalculateFibonacci(1));
        }
        int CalculateFibonacci(int n)
        {
            if (n < 2) return n;
            return 0;
        }
    }
}
