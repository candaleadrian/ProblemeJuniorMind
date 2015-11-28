using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class Pangram
    {
        [TestMethod]
        public void PangramTest1()
        {
            Assert.AreEqual("a", decideIfIsAPangram("a", "ab"));
        }
        string decideIfIsAPangram(string alfabet, string text)
        {
            return "";
        }
    }
}
