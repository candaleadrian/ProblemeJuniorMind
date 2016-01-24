using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void ShouldReturnTheNumberIfNoOperation()
        {
            Assert.AreEqual(1, Calculate("1"));
        }
        [TestMethod]
        public void ShouldReturnDoubleNumberAsResult()
        {
            Assert.AreEqual(1.5, Calculate("1.5"));
        }
        //[TestMethod]
        //public void ShouldReturnSumBetweenOneAndOne()
        //{
        //    Assert.AreEqual(2, Calculate("+ 1 1"));
        //}
        //[TestMethod]
        //public void ShouldReturnSumBetweenMinusOneAndOne()
        //{
        //    Assert.AreEqual(0, Calculate("+ -1 1"));
        //}
        //[TestMethod]
        //public void ShouldReturnSumBetweenMinusOneAndMinusOne()
        //{
        //    Assert.AreEqual(-2, Calculate("+ -1 -1"));
        //}
        //[TestMethod]
        //public void ShouldReturnSumBetweenOneAndOneAndOne()
        //{
        //    Assert.AreEqual(3, Calculate("+ + 1 1 1"));
        //}
        public double Calculate(string operation)
        {
            int position = 0;
            string[] opArray = operation.Split(' ');
            return Calculate(opArray, position);
        }
        
        private double Calculate(string[] operation, int position)
        {
            double result;
            if (double.TryParse(operation[position], out result))
            {
                return result;
            }
            return 0;
        }
    }
}
