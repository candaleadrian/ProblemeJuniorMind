using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inversion
{
    [TestClass]
    public class Inversion
    {
        [TestMethod]
        public void InverseOneCharString()
        {
            Assert.AreEqual("a", InverseString("a"));
        }
        [TestMethod]
        public void InverseTwoCharString()
        {
            Assert.AreEqual("ba", InverseString("ab"));
        }
        [TestMethod]
        public void InverseThreeCharString()
        {
            Assert.AreEqual("cba", InverseString("abc"));
        }
        public string InverseString(string str)
        {
            if (str.Length <= 1) return str;
            return InverseString(str.Substring(1))+str[0];
        }
    }
}
