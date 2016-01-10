using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class Password
    {
        [TestMethod]
        public void ShouldReturnARandomPasswordContainingSixRandomLeters()
        {
            Assert.AreEqual(6,GeneratePassword(Options).Length);
        }
        [TestMethod]
        public void ShouldReturnTwoRandomPasswordContainingSixRandomLeters()
        {
            var first = GeneratePassword(Options);
            var second = GeneratePassword(Options);
            Assert.AreNotEqual(first, second);
        }
        [TestMethod]
        public void ShouldScheckUpperCaseRandomLeters()
        {
            var first = GeneratePassword(Options);
            first.Contains(char.IsUpper);
            Assert.AreNotEqual(first, second);
        }
        string GeneratePassword(PasswordOptions[] Option)
        {
            string password = string.Empty;
            if (Options[0].upperCaseCharacters>0)
                password += ReturnRandomStringKnowingLengthAndAsciRange(Options[0].upperCaseCharacters, 65, 91);
            if (password.Length<Options[0].length)
            password += ReturnRandomStringKnowingLengthAndAsciRange(Options[0].length-password.Length, 97,123);
            return password;
        }

        private string ReturnRandomStringKnowingLengthAndAsciRange(int length, int minRange, int maxRange)
        {
            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                password += (char)random.Next(minRange, maxRange);
            }

            return password;
        }

        public Random random = new Random();
        public struct PasswordOptions
        {
            public int length;
            public int upperCaseCharacters;
        }
        public PasswordOptions[] Options =
        {
            new PasswordOptions {length = 6, upperCaseCharacters = 3 }
        };
    }
}
