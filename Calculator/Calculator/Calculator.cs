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
        public void ShouldReturnSumBetweenOneAndOneAndOne()
        {
            Assert.AreEqual(3, Calculate("+ + 1 1 1"));
        }
        [TestMethod]
        public void ShouldReturnOne()
        {
            Assert.AreEqual(1, FindFirstOpertion(new string[] {"+","+","1","1","1" }));
        }
        [TestMethod]
        public void ShouldReturnZero()
        {
            Assert.AreEqual(0, FindFirstOpertion(new string[] { "+", "1", "1", "1" }));
        }
        [TestMethod]
        public void ShouldReturnNewStringWithoutFirstOperation()
        {
            Assert.AreEqual("+ 2 1", CreateNewOperationString(1,new string[] { "+", "+", "1", "1", "1" }));
        }
        [TestMethod]
        public void ShouldReturnOneForStringOne()
        {
            Assert.AreEqual(1, TransformFromStringToInt("1"));
        }
        public int Calculate(string operation)
        {
            int num1;
            int num2;
            string[] opArray = operation.Split(' ');
            num1 = TransformFromStringToInt(opArray[1]);
            num2 = TransformFromStringToInt(opArray[2]);
            if (opArray.Length<4)
                return num1 + num2;
            Calculate(CreateNewOperationString(FindFirstOpertion(opArray),opArray));
            return 0;
        }
        public int TransformFromStringToInt(string transformString)
        {
            int num;
            return int.TryParse(transformString,out num) ? num: 0;
        }
        public int FindFirstOpertion(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int num;
                if (int.TryParse(array[i], out num))
                {
                    return i - 1;
                }
            }
            return 0;
        }
        public string CreateNewOperationString(int num, string[] operation)
        {
            string result = string.Empty;
            for (int i = 0; i < operation.Length; i++)
            {
                if (i == num + 1 && i == num + 2)
                {
                    result += "";
                }
                if (i == num)
                {
                    result += Operation(operation[i + 1], operation[i + 2]);
                }
                else 
                {
                    if (i < operation.Length - 2)
                        result += operation[i];
                }
                result += " ";
            }
            return result;
        }

        private string Operation(string v1, string v2)
        {
            return ((TransformFromStringToInt(v1)+TransformFromStringToInt(v2)).ToString());
        }
    }
}
