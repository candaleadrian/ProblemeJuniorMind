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
            Assert.AreEqual("YES", decideIfIsAPangram("a", "ab"));
        }
        [TestMethod]
        public void PangramTest2()
        {
            Assert.AreEqual("YES", decideIfIsAPangram("ab", "ab"));
        }
        [TestMethod]
        public void PangramTestNO()
        {
            Assert.AreEqual("NO", decideIfIsAPangram("ab", "cdefg"));
        }
        [TestMethod]
        public void PangramTestFinal()
        {
            Assert.AreEqual("YES", decideIfIsAPangram("abcdefghijklmnopqrstuvwxyz", "The quick brown fox jumps over the lazy dog"));
        }
        string decideIfIsAPangram(string alfabet, string text)
        {
            for (int i = 0; i < alfabet.Length; i++)
            {
                if (text.Contains(alfabet[i]))
                {
                    if (i == (alfabet.Length - 1))
                    {
                        return "YES";
                    }
                }
            }
            return "NO";
        }
    }
}
