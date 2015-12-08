using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, CalculateAnagramsNumber("ab"));
        }
        [TestMethod]
        public void Test3CharTest()
        {
            Assert.AreEqual(6, CalculateAnagramsNumber("abc"));
        }
        [TestMethod]
        public void Test4CharTest()
        {
            Assert.AreEqual(24, CalculateAnagramsNumber("abcd"));
        }
        [TestMethod]
        public void Test3CharTestAAB()
        {
            Assert.AreEqual(3, CalculateAnagramsNumber("aab"));
        }
        [TestMethod]
        public void Test3CharTestAAAB()
        {
            Assert.AreEqual(4, CalculateAnagramsNumber("aaab"));
        }
        [TestMethod]
        public void Test3CharTestAAAA()
        {
            Assert.AreEqual(1, CalculateAnagramsNumber("aaaa"));
        }
        int CalculateAnagramsNumber(string text)
        {
            int anagramNumber = 1;
            int counter = 1;
            string newString = "";
            int b = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (GoThroughText(text, text[i]) >= 1)
                {
                    if (GoThroughText(newString, text[i]) < 1)
                    {
                        newString = newString + text[i];
                        if (GoThroughText(text, text[i])>1)
                        {
                        b = b + GoThroughText(text, text[i]);
                        }
                    }
                }
            }
            if (newString.Length != text.Length)
            {
                counter = b;
            }            
            int anagramFinal = duplicateFactorial(text.Length)/duplicateFactorial(counter); 
            return anagramFinal;
        }
        private static int GoThroughText(string text, char charToCheck)
        {
            int contained = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==charToCheck)
                {
                    contained++;
                }
            }
                return contained;
        }
        [TestMethod]
        public void FactorialTestForNumber2()
        {
            Assert.AreEqual(2, duplicateFactorial(2));
        }
        [TestMethod]
        public void FactorialTestForNumber3()
        {
            Assert.AreEqual(6, duplicateFactorial(3));
        }
        public int duplicateFactorial(int numFactor)
        {
            int factorial = 1;
            for (int i = 1; i <= numFactor; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
