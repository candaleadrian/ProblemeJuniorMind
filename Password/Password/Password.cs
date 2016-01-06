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
            Assert.AreEqual(1, GeneratePassword(1,1).Length);
        }
        [TestMethod]
        public void ShouldReturnARandomValueSmallerThenSix()
        {
            Assert.IsTrue(ReturnRandomNumberFromNullToSpecified(6)<6);
        }
        [TestMethod]
        public void ShouldReturnARandomPasswordContainingThreeRandomLeters()
        {
            Assert.AreEqual(3,GeneratePassword(3,1).Length);
        }
        string GeneratePassword(int passLength, byte option)
        {
            string password = "";
            for (int i = 0; i < passLength; i++)
            {
                password += Options[0].type[random.Next(0, Options[0].type.Length)];
            }
            return password;
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
