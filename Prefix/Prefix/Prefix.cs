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
        string findComunPrefix(string firstWord, string secondWord)
        {
            return "";
        }
    }
}
