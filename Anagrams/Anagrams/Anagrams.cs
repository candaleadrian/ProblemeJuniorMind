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
        int CalculateAnagramsNumber(string text)
        {
            int anagramNumber = 1;
            int counter = 1;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i+1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        counter++;
                    }
                    j++;
                }
                i++;
            }
            for (int i = 0; i < text.Length; i++)
                anagramNumber = anagramNumber * (text.Length - i);
            int anagramFinal = anagramNumber/duplicateFactorial(counter); 
            return anagramFinal;
        }

        public  int duplicateFactorial(int number)
        {
            if (number   > 1)
            {
                for (int i = 1; i < number  ; i++)
                {
                    number= number * i;      
                }
                return number;
            }
            return 1;
        }
    }
}
