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
        [TestMethod]
        public void ShouldReturnSumBetweenOneAndOne()
        {
            Assert.AreEqual(2, Calculate("+ 1 1"));
        }
        [TestMethod]
        public void ShouldReturnSumBetweenOneAndTwo()
        {
            Assert.AreEqual(3, Calculate("+ 1 2"));
        }
        [TestMethod]
        public void ShouldReturnSumBetweenMinusOneAndOne()
        {
            Assert.AreEqual(0, Calculate("+ -1 1"));
        }
        [TestMethod]
        public void ShouldReturnSumBetweenMinusOneAndMinusOne()
        {
            Assert.AreEqual(-2, Calculate("+ -1 -1"));
        }
        [TestMethod]
        public void ShouldReturnSumBetweenMinusOneTwoThreeAndMinusOne()
        {
            Assert.AreEqual(3, Calculate("+ + + -1 2 3 -1"));
        }
        [TestMethod]
        public void ShouldReturnSumBetweenOneAndOneAndOne()
        {
            Assert.AreEqual(3, Calculate("+ + 1 1 1"));
        }
        [TestMethod]
        public void ShouldReturnSumBetweenTwoStrings()
        {
            Assert.AreEqual(8.74, Calculate("+ + + + -1 2 3 -1 + 3.53 2.21"));
        }
        [TestMethod]
        public void ShouldReturnDifferenceBetweenTwoAndOne()
        {
            Assert.AreEqual(1, Calculate("- 2 1"));
        }
        [TestMethod]
        public void ShouldReturnDifferenceBetweenTwoPointFiveAndSixPointSeven()
        {
            Assert.AreEqual(-4.2, Calculate("- 2.5 6.7"));
        }
        public double Calculate(string operation)
        {
            int position = 0;
            string[] opArray = operation.Split(' ');
            return Calculate(opArray, ref position);
        }
        
        private double Calculate(string[] operation,ref int position)
        {
            double result;
            if (double.TryParse(operation[position], out result))
            {
                position++;
                return result;
            }
            string op = operation[position];
            position++;
            return Operation(operation, op, ref position);
        }

        private double Operation(string[] operation, string op, ref int position)
        {
            switch (op)
            {
                case "+":
                    return Calculate(operation, ref position) + Calculate(operation, ref position);
                case "-":
                    return Calculate(operation, ref position) - Calculate(operation, ref position);
                default:
                    return 0;
            }
        }
    }
}
