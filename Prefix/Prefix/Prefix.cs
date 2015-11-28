using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class Prefix
    {
        [TestMethod]
        public void TestCharA()
        {
            Assert.AreEqual("a", findComunPrefix("abc", "acb"));
        }
        [TestMethod]
        public void TestCharAa()
        {
            Assert.AreEqual("aa", findComunPrefix("aabc", "aacb"));
        }
        [TestMethod]
        public void TestCharNull()
        {
            Assert.AreEqual("", findComunPrefix("zabc", "aacb"));
        }
        string findComunPrefix(string firstWord, string secondWord)
        {
            string prefix = "";
            for (int i = 0; i < Math.Min(firstWord.Length,secondWord.Length); i++)
            {
                if (firstWord[i] == secondWord[i])
                {
                    prefix = prefix + firstWord[i];
                }
            }
            return prefix;
        }
    }
}
