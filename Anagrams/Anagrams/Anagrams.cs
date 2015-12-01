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
        int CalculateAnagramsNumber(string text)
        {
            int anagramNumber = 1;
            for (int i = 0; i < text.Length; i++)
            {
                anagramNumber = anagramNumber * (text.Length - i); 
            }
            return anagramNumber ;
        }
    }
}
