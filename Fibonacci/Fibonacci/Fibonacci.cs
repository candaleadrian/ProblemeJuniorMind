using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class Fibonacci
    {
        [TestMethod]
        public void ShouldReturnFibonacciSumForOne()
        {
            Assert.AreEqual(0,CalculateFibonacci(0));
        }
        int CalculateFibonacci(int n)
        {
            return 0;
        }
    }
}
