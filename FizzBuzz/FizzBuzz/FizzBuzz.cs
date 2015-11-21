using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestNr3()
        {
            Assert.AreEqual("Fizz", FizzOrBuzz(3));
        }
        [TestMethod]
        public void TestNr5()
        {
            Assert.AreEqual("Buzz", FizzOrBuzz(5));
        }
        string FizzOrBuzz(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "FFFFFizz";
            }

            else
            {
                return "not multiple of 3";
            }
        }
    }
}
