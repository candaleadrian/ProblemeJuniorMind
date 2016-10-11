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
        public void ShoulReturnOne()
        {
            Assert.AreEqual(1, GetNumber(7));
        }
        [TestMethod]
        public void ShoulReturnPlus()
        {
            Assert.AreEqual(1, GetNumber(7));
        }
        int counterNr = 0;
        int counterSign = -1;
        public int GetNumber(int number)
        {
            counterNr += 1;
            if (counterNr > number)
                return -1;
            return counterNr;
        }
        public string GetSign()
        {
            string[] op = new string[0];
            int[] numbers = {1, 2};
            string[] operation = {"+","-"};
            op = Combine(numbers, operation);
            return op[0];
        }

        public string[] Combine(int[] numbers, string[] operation)
        {
            string[] result = new string[0];
            string tmp = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                tmp += numbers[i];
                for (int j = 0; j < operation.Length; j++)
                {
                    tmp += operation[j];
                }
            }
            return result;
        }
    }
}
