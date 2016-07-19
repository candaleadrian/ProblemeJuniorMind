using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2
{
    public class Pasword
    {
        public static string GeneratePassword(PasswordOptions Options)
        {
            string password = string.Empty;
            password += ReturnRandomSymbolsStringKnowingLength(Options.symbols, Options.ambiguous);
            password += GenerateRandomString(Options.numbers, '0', '9' + 1, Options.similar);
            password += GenerateRandomString(Options.upperCaseCharacters, 'A', 'Z' + 1, Options.similar);
            password += GenerateRandomString(Options.length - password.Length, 'a', 'z' + 1, Options.similar);
            password = ShuffleString(password);
            return password;
        }
        private static string ShuffleString(string password)
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
        private static bool CheckIfCharIsContaindInSimilarString(char charToCheck, string stringToCheck)
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
        private static string ReturnRandomSymbolsStringKnowingLength(int length, bool ambiguous)
        {
            string password = string.Empty;
            string symbols = "!@#$%^&*()_+{}[]()/\'~,;.<>" + '"';
            for (int i = 0; i < length; i++)
            {
                int rnd = (char)random.Next(0, symbols.Length);
                char temp = symbols[rnd];
                while (ambiguous && CheckIfCharIsContaindInSimilarString(temp, "{}[]()/\'~,;.<> " + '"'))
                {
                    rnd = (char)random.Next(0, symbols.Length);
                    temp = symbols[rnd];
                }
                password += symbols[rnd];
            }
            return password;
        }
        private static string GenerateRandomString(int length, int minRange, int maxRange, bool similar)
        {
            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                char temp = (char)random.Next(minRange, maxRange);
                while (similar && CheckIfCharIsContaindInSimilarString(temp, "1l0oO"))
                {
                    temp = (char)random.Next(minRange, maxRange);
                }
                password += temp;
            }
            return password;
        }
        public static Random random = new Random();
        public struct PasswordOptions
        {
            public int length;
            public int upperCaseCharacters;
            public int numbers;
            public int symbols;
            public bool similar;
            public bool ambiguous;
            public PasswordOptions(int length, int upperCaseCharacters, int numbers, int symbols, bool similar, bool ambiguous)
            {
                this.length = length;
                this.upperCaseCharacters = upperCaseCharacters;
                this.numbers = numbers;
                this.symbols = symbols;
                this.similar = similar;
                this.ambiguous = ambiguous;
            }
        }
    }
}