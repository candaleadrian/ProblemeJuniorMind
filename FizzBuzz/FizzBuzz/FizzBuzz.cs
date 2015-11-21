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
        string FizzOrBuzz(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return "not multiple of 3";
            }
        }
    }
}
