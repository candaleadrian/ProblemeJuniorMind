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
            Assert.AreEqual ("I", TransformArabicToRoman(1));
        }
        [TestMethod]
        public void Transform2toRoman()
        {
            Assert.AreEqual("II", TransformArabicToRoman(2));
        }
        string TransformArabicToRoman(int number)
        {
            int remainder = number % 10;
            switch (remainder)
            {
                case 1:
                    return "I";
                    break;
                case 2:
                    return "II";
                    break;
                default:
                    return "0";
            }
        }
    }
}
