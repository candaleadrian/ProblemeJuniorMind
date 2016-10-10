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
        [TestMethod]
        public void ShoulReturnZeroPlusOnePlusThreePlusFourForRangeThreeAndNumberOne()
        {
            int range = 2;
            int number = 1;
            Assert.AreEqual("2+1+0", CalculateCombination(range, number));
        }
        [TestMethod]
        public void ShoulReturnTwoMinusOnePlusZeroAndNumberOne()
        {
            int range = 2;
            int number = 1;
            Assert.AreEqual("2-1-0", CalculateCombination(range, number));
        }
        //public string[] ReturnAllVariants(int range, int number)
        //{
        //    CalculateCombination(range, number);
        //    return new string[0];
        //}

        public string CalculateCombination(int range, int number)
        {
            string result = string.Empty;
            int range2 = range;
            if (range == 0)
            {
                return result + "0";
            }
            result = range + "-" + CalculateCombination(range-1, number);
            result = range + "+" + CalculateCombination(range2-1, number);
           return result;
        }
    }
}
