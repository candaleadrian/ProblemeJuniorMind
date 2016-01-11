﻿using System;
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
        [TestMethod]
        public void ShouldCheckIfFunctionReplaceAmbiguousCharacters()
        {
            string password = "pp44{>;";
            string result = ReplaceAmbiguousCharacters(password);
            Assert.AreNotEqual(password, result);
        }
        [TestMethod]
        public void ShouldCheckIfShuffleFunctionWorks()
        {
            string password = "pp44{>;mkft0754sdfsdf";
            string result1 = ShuffleString(password);
            string result2 = ShuffleString(password);
            Assert.AreNotEqual(result1, result2);
        }
        string GeneratePassword(PasswordOptions Options)
        {
            string password = string.Empty;
            password += ReturnRandomSymbolsStringKnowingLength(Options.symbols);
            password += GenerateRandomString(Options.numbers, 48, 58);
            password += GenerateRandomString(Options.upperCaseCharacters, 65, 91);
            password += GenerateRandomString(Options.length - password.Length, 97, 123);
            password = ReplaceSimilarLeters(password);
            password = ReplaceAmbiguousCharacters(password);
            password = ShuffleString(password);
            return password;
        }
        private string ShuffleString(string password)
        {
            char[] array = password.ToCharArray();
            for (int i = 0; i < array.Length * random.Next(array.Length, array.Length * 10); i++)
            {
                int j = random.Next(0, array.Length);
                char reminder = array[j];
                int z = random.Next(0, array.Length);
                array[j] = array[z];
                array[z] = reminder;
            }
            return new string(array);
        }
        private string ReplaceAmbiguousCharacters(string password)
        {
            char[] array = password.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                while (CheckIfCharIsContaindInSimilarString(array[i], "{}[]()/\'~,;.<> "+'"'))
                {
                        array[i] = TransformOneLetterStringToChar(ReturnRandomSymbolsStringKnowingLength(1));
                }
            }
            return new string(array);
        }
        private string ReplaceSimilarLeters(string password)
        {
            char[] array = password.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                while (CheckIfCharIsContaindInSimilarString(array[i], "1l0oO"))
                {
                    if (char.IsLower(array[i]))
                    array[i] = TransformOneLetterStringToChar(GenerateRandomString(1, 97, 123));
                    if (char.IsUpper(array[i]))
                        array[i] = TransformOneLetterStringToChar(GenerateRandomString(1, 65, 91));
                    if (char.IsNumber(array[i]))
                        array[i] = TransformOneLetterStringToChar(GenerateRandomString(1, 48, 58));
                }
            }
            return new string(array);
        }
        private bool CheckIfCharIsContaindInSimilarString(char charToCheck, string stringToCheck)
        {
            foreach (char item in stringToCheck)
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
        private string GenerateRandomString(int length, int minRange, int maxRange)
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
            public bool ambiguous;
        }
    }
}
