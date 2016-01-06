using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class Password
    {
        [TestMethod]
        public void ShouldReturnAPaswordContainingOneRandomLeter()
        {
            Assert.AreEqual(0, GeneratePassword(3,1).Length);
        }
        [TestMethod]
        public void ShouldReturnARandomValueSmallerThenSix()
        {
            Assert.IsTrue(ReturnRandomNumberFromNullToSpecified(6)<6);
        }
        string GeneratePassword(int passLength, byte option)
        {
            return "";
        }
        public Random random = new Random();
        int ReturnRandomNumberFromNullToSpecified(int upperLimit)
        {
            return random.Next(0,upperLimit);
        }
        public struct PasswordOptions
        {
            public string name;
            public string type;
            public int number;
            public int selectionNumber;
        }
        public PasswordOptions[] Options =
        {
            new PasswordOptions {name = "smallLeters", type = "abcdefghijklmnopqrstuvwxyz",number = 6, selectionNumber=1 }
        };
    }
}
