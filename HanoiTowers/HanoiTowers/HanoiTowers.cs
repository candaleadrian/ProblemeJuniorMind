using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class HanoiTowers
    {
        [TestMethod]
        public void ShouldReturnTheMoveForOneDisk()
        {
            Assert.AreEqual("AC",Solution(1,'A','B','C'));
        }
        [TestMethod]
        public void ShouldReturnTheMoveForTwoDisc()
        {
            Assert.AreEqual("AB AC BC", Solution(2, 'A', 'B', 'C'));
        }
        [TestMethod]
        public void ShouldReturnTheMoveForThreeDisk()
        {
            Assert.AreEqual("AC AB CB AC BA BC AC", Solution(3, 'A', 'B', 'C'));
        }
        [TestMethod]
        public void ShouldReturnTheNumberOfMovesForTenDisks()
        {
            int expected = (int)Math.Pow(2, 10) - 1;
            int result = Solution(10, 'A', 'B', 'C').Split(' ').Length;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ShouldReturnTheNumberOfMovesForTwentyDisks()
        {
            int expected = (int)Math.Pow(2, 20) - 1;
            int result = Solution(20, 'A', 'B', 'C').Split(' ').Length;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ShouldReturnTheNumberOfMovesForThirtyDisks()
        {
            int expected = (int)Math.Pow(2, 25) - 1;
            int result = Solution(25, 'A', 'B', 'C').Split(' ').Length;
            Assert.AreEqual(expected, result);
        }
        public string Solution(int n, char source, char aux, char destination)
        {
            string result = string.Empty;
            if (n == 1)
                return $"{source}{destination}";
            result += Solution(n-1, source, destination, aux);
            result += " " + Solution(1, source, aux, destination);
            return result += " " + Solution(n-1, aux, source, destination);
        }
    }
}
