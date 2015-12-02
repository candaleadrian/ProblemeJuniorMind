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
        int CalculateAnagramsNumber(string text)
        {
            char[] charactersArray = { };
            int anagramNumber = 1;
            foreach (char character in text)
            {
                if (charactersArray.(character) )
                {
                    
                }
            }
//            for (int i = 0; i < text.Length; i++)
//            {
//                Array.Resize(ref charactersArray, charactersArray.Length + 1);
//                if (char text[i] included inn chararr)
//                {
//                    charactersArray[charactersArray.Length - 1] = text[i];
//                return 1;
//                }
//                anagramNumber = anagramNumber * (text.Length - i); 
//            }
            return 1;
        }
    }
}
