using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArabicToRoman
{
    [TestClass]
    public class ArabicToRoman
    {
        [TestMethod]
        public void Transform1toRoman()
        {
            Assert.AreEqual("I", 1);
        }
        string TransformArabicToRoman(int number)
        {
            return "O";
        }
    }
}
