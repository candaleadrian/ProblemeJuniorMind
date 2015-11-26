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
        [TestMethod]
        public void Transform3toRoman()
        {
            Assert.AreEqual("III", TransformArabicToRoman(3));
        }
        [TestMethod]
        public void Transform4toRoman()
        {
            Assert.AreEqual("IV", TransformArabicToRoman(4));
        }
        [TestMethod]
        public void Transform5toRoman()
        {
            Assert.AreEqual("V", TransformArabicToRoman(5));
        }
        [TestMethod]
        public void Transform6toRoman()
        {
            Assert.AreEqual("VI", TransformArabicToRoman(6));
        }
        [TestMethod]
        public void Transform7toRoman()
        {
            Assert.AreEqual("VII", TransformArabicToRoman(7));
        }
        [TestMethod]
        public void Transform8toRoman()
        {
            Assert.AreEqual("VIII", TransformArabicToRoman(8));
        }
        [TestMethod]
        public void Transform9toRoman()
        {
            Assert.AreEqual("IX", TransformArabicToRoman(9));
        }
        [TestMethod]
        public void Transform10toRoman()
        {
            Assert.AreEqual("X", TransformArabicToRoman(10));
        }
        string TransformArabicToRoman(int number)
        {
            int remainder = number % 10;
            return RomanNumberLessThenTen(remainder);

         //   return "X";
        }

        private static string RomanNumberLessThenTen(int remainder)
        {
            switch (remainder)
            {
                case 1:
                    return "I";
                    break;
                case 2:
                    return "II";
                    break;
                case 3:
                    return "III";
                    break;
                case 4:
                    return "IV";
                    break;
                case 5:
                    return "V";
                    break;
                case 6:
                    return "VI";
                    break;
                case 7:
                    return "VII";
                    break;
                case 8:
                    return "VIII";
                    break;
                case 9:
                    return "IX";
                    break;
                case 0:
                    return "X";
                    break;
                default:
                    return "0";
            }
        }
    }
}
