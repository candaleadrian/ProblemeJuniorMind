using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlusOrMinusToCalculateNumber
{
    [TestClass]
    public class PlusOrMinus
    {
        [TestMethod]
        public void ShoulReturnZeroPlusOneForRangeOneAndNumberOne()
        {
            int range = 1;
            int number = 1;
            Assert.AreEqual("1+0", CalculateCombination(range, number));
        }
        [TestMethod]
        public void ShoulReturnZeroPlusOnePlusThreeForRangeTwoAndNumberOne()
        {
            int range = 2;
            int number = 1;
            Assert.AreEqual("2+1+0", CalculateCombination(range, number));
        }
        public string[] ReturnAllVariants(int range, int number)
        {
            CalculateCombination(range, number);
            return new string[0];
        }

        public string CalculateCombination(int range, int number)
        {
            string result = string.Empty;
            if (range == 1)
            {
                return "1+0";
            }
            result += range + "+";
            return result += CalculateCombination(range - 1, number);
        }
    }
}
