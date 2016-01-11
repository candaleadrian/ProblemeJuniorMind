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
            var option = new PasswordOptions { length = 6, upperCaseCharacters = 3 };
            Assert.AreEqual(6,GeneratePassword(option).Length);
        }
        [TestMethod]
        public void ShouldReturnTwoRandomPasswordContainingSixRandomLeters()
        {
            var option = new PasswordOptions { length = 6, upperCaseCharacters = 3 };
            var first = GeneratePassword(option);
            var second = GeneratePassword(option);
            Assert.AreNotEqual(first, second);
        }
        [TestMethod]
        public void ShouldScheckUpperCaseRandomLetersNumber()
        {
            var option = new PasswordOptions { length = 6, upperCaseCharacters = 3 };
            string password = GeneratePassword(option);
            int result = 0;
            foreach (var item in password)
            {
                if (char.IsUpper(item))
                    result++;
            }
            Assert.AreEqual(3,result);
        }
        [TestMethod]
        public void ShouldCheckHowManyNumbersAreInThePassword()
        {
            var option = new PasswordOptions { length = 6, upperCaseCharacters = 3, numbers = 2};
            string password = GeneratePassword(option);
            int result = 0;
            foreach (var item in password)
            {
                if (char.IsNumber(item))
                    result++;
            }
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void ShouldCheckHowManyNumbersAreInThePasswordIfNoUpperCase()
        {
            var option = new PasswordOptions { length = 6, upperCaseCharacters = 0, numbers = 2 };
            string password = GeneratePassword(option);
            int result = 0;
            foreach (var item in password)
            {
                if (char.IsNumber(item))
                    result++;
            }
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void ShouldCheckHowManySymbolsAreInThePassword()
        {
            var option = new PasswordOptions { length = 8, upperCaseCharacters = 3, numbers = 2, symbols =2 };
            string password = GeneratePassword(option);
            int result = 0;
            foreach (var item in password)
            {
                if (!char.IsNumber(item) && !char.IsUpper(item) && !char.IsLower(item))
                    result++;
            }
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void ShouldCheckIfFunctionReplaceSimilarCharacters()
        {
            string password = "45tyildb0soO";
            string result = ReplaceSimilarLeters(password);
            Assert.AreNotEqual(password, result);
        }
        string GeneratePassword(PasswordOptions Options)
        {
            string password = string.Empty;
            if (Options.symbols > 0)
                password += ReturnRandomSymbolsStringKnowingLength(Options.symbols);
            if (Options.numbers > 0)
                password += ReturnRandomStringKnowingLengthAndAsciRange(Options.numbers, 48, 58);
            if (Options.upperCaseCharacters>0)
                password += ReturnRandomStringKnowingLengthAndAsciRange(Options.upperCaseCharacters, 65, 91);
            if (password.Length<Options.length)
                password += ReturnRandomStringKnowingLengthAndAsciRange(Options.length-password.Length, 97,123);
            if (Options.similar)
                password = ReplaceSimilarLeters(password);
            return password;
        }
        private string ReplaceSimilarLeters(string password)
        {
            char[] array = password.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                while (CheckIfCharIsContaindInSimilarString(array[i]))
                {
                    array[i] = TransformOneLetterStringToChar(ReturnRandomStringKnowingLengthAndAsciRange(1, 97, 123));
                }
            }
            return new string(array);
        }
        private bool CheckIfCharIsContaindInSimilarString(char charToCheck)
        {
            string similar = "1l0oO";
            foreach (char item in similar)
            {
                if (item == charToCheck)
                    return true;
            }
            return false;
        }
        private char TransformOneLetterStringToChar(string letter)
        {
            char[] array = letter.ToCharArray();
            return array[0];
        }
        private bool CheckIfCharIsContaindInAString(string stringTocheck, char charToCheck)
        {
            char[] charArray = stringTocheck.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == charToCheck)
                    return true;
            }
            return false;
        }
        private string ReturnRandomSymbolsStringKnowingLength(int length)
        {
            string password = string.Empty;
            string symbols = "!@#$%^&*()_+{}[]()/\'~,;.<>"+'"';
            for (int i = 0; i < length; i++)
            {
                int rnd = (char)random.Next(0, symbols.Length);
                password += symbols[rnd];
            }
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
            public int numbers;
            public int symbols;
            public bool similar;
        }
    }
}
