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
            string newString = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (GoThroughText(text,text[i])>=1)
                {
                    if (GoThroughText(newString, text[i])<1)
                    {
                        newString = newString + text[i];
                    }
                }
            }
            if (newString.Length != text.Length)
            {
                counter = newString.Length;
            }
            
            for (int i = 0; i < text.Length; i++)
                anagramNumber = anagramNumber * (text.Length - i);
            int anagramFinal = anagramNumber/duplicateFactorial(counter); 
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

        public int duplicateFactorial(int number)
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
