using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            for (int i = 0; i < alfabet.Length; i++)
            {
                if (text.Contains(alfabet[i]))
                {
                    return "a";
                }
            }
            return "";
        }
    }
}
