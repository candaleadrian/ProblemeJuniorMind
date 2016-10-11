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
            Assert.AreEqual("1+2", Combine(new int[] {1,2}));
        }
        
        int counterNr = 0;
        int counterSign = -1;
        public string Combine(int[] numbers)
        {
            string result = string.Empty;
            int opNr = numbers.Length;
            while (counterSign < 0)
            {
                for (int i = 0; i < opNr; i++)
                {
                    result += numbers[i] + GetOperation();
                }
            }
            return result;
        }

        private string GetOperation()
        {
            counterSign = 1;
            string[] operation = { "+", "-" };
            while (counterSign == 1)
            {
            if (counterNr == 0)
                return "+";
            }
            throw new NotImplementedException();
        }
    }
}
