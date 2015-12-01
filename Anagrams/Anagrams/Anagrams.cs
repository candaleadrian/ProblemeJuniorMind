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
        int CalculateAnagramsNumber(string text)
        {
            int anagramNumber = 0;
            for (int i = 1; i < text.Length; i++)
            {
                anagramNumber = text.Length * (text.Length - i) / (text.Length - 1);
            }
            return anagramNumber ;
        }
    }
}
