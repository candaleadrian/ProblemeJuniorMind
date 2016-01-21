using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void ShouldReturnSumBetweenOneAndOne()
        {
            Assert.AreEqual(2, Calculate("+ 1 1"));
        }
        public int Calculate(string operation)
        {
            int num1;
            int num2;
            string[] opArray = operation.Split(' ');
            int.TryParse(opArray[1], out num1);
            int.TryParse(opArray[2], out num2);
            return num1 + num2;
        }
    }
}
