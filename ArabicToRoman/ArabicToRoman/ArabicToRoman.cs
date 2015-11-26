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
        [TestMethod]
        public void Transform11toRoman()
        {
            Assert.AreEqual("XI", TransformArabicToRoman(11));
        }
        [TestMethod]
        public void Transform15toRoman()
        {
            Assert.AreEqual("XV", TransformArabicToRoman(15));
        }
        [TestMethod]
        public void Transform19toRoman()
        {
            Assert.AreEqual("XIX", TransformArabicToRoman(19));
        }
        [TestMethod]
        public void Transform20toRoman()
        {
            Assert.AreEqual("XX", TransformArabicToRoman(20));
        }
        [TestMethod]
        public void Transform21toRoman()
        {
            Assert.AreEqual("XXI", TransformArabicToRoman(21));
        }
        [TestMethod]
        public void Transform29toRoman()
        {
            Assert.AreEqual("XXIX", TransformArabicToRoman(29));
        }
        [TestMethod]
        public void Transform39toRoman()
        {
            Assert.AreEqual("XXXIX", TransformArabicToRoman(39));
        }
        [TestMethod]
        public void Transform40toRoman()
        {
            Assert.AreEqual("XL", TransformArabicToRoman(40));
        }
        [TestMethod]
        public void Transform49toRoman()
        {
            Assert.AreEqual("XLIX", TransformArabicToRoman(49));
        }
        [TestMethod]
        public void Transform50toRoman()
        {
            Assert.AreEqual("L", TransformArabicToRoman(50));
        }
        [TestMethod]
        public void Transform59toRoman()
        {
            Assert.AreEqual("LIX", TransformArabicToRoman(59));
        }
        [TestMethod]
        public void Transform89toRoman()
        {
            Assert.AreEqual("LXXXIX", TransformArabicToRoman(89));
        }
        [TestMethod]
        public void Transform90toRoman()
        {
            Assert.AreEqual("XC", TransformArabicToRoman(90));
        }
        [TestMethod]
        public void Transform99toRoman()
        {
            Assert.AreEqual("XCIX", TransformArabicToRoman(99));
        }
        string TransformArabicToRoman(int number)
        {
            int remainder = number % 10;
            string additionalNumber = RomanNumberLessThenTen(remainder);
            string DousensRoman = "";
            string fiftyOrNinety = "";
            if (number >= 50 && number < 90)
            {
                number = number - 50;
                fiftyOrNinety = "L";
            }
            if (number >= 90)
            {
                number = number - 90;
                fiftyOrNinety = "XC";
            }
            if ((number / 10) == 4 && (number / 10) <5)
            {
                DousensRoman = "XL";
            }
            else if ((number / 10) > 0 && (number / 10) < 5)
            {
                for (int i = 0; i < (number / 10); i++)
                {
                    DousensRoman = DousensRoman + "X";
                }
               
            }
            string romanNumber = fiftyOrNinety + DousensRoman + additionalNumber ;
            return romanNumber ;
        }

        private static void dousens(int number)
        {
            if (number > 10)
            {
                int dousen = number / 10;
            }
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
                default:
                    return "";
            }
        }
    }
}
