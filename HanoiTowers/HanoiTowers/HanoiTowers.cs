using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class HanoiTowers
    {
        [TestMethod]
        public void ShouldReturnTheMoveForOneDisc()
        {
            Assert.AreEqual("AC",Solution(1,'A','B','C'));
        }
        [TestMethod]
        public void ShouldReturnTheMoveForTwoDisc()
        {
            Assert.AreEqual("AB AC BC", Solution(2, 'A', 'B', 'C'));
        }
        [TestMethod]
        public void ShouldReturnTheMoveForThreeDisc()
        {
            Assert.AreEqual("AC AB CB AC BA BC AC", Solution(3, 'A', 'B', 'C'));
        }
        public string Solution(int n, char source, char destination, char aux)
        {
            string result = string.Empty;
            if (n <= 1)
                return $"{source}{aux}";
            result += Solution(n-1, source, aux, destination);
            result += " " + Solution(1, source, destination, aux);
            return result += " " + Solution(n-1, destination, source, aux);
        }
    }
}
