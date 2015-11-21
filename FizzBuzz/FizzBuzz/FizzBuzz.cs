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
        [TestMethod]
        public void TestNr15()
        {
            Assert.AreEqual("FizzBuzz", FizzOrBuzz(15));
        }
        string FizzOrBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "not multiple of 3";
            }
        }
    }
}
