using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void ShouldReturnTheFirstLine()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, Generate(0));
        }
        [TestMethod]
        public void ShouldReturnTheSecondLine()
        {
            CollectionAssert.AreEqual(new int[] { 1 , 1 }, Generate(1));
        }
        [TestMethod]
        public void ShouldReturnTheThirdLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, Generate(2));
        }
        [TestMethod]
        public void ShouldReturnTheFourthLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 3, 1 }, Generate(3));
        }
        [TestMethod]
        public void ShouldReturnTheFifthLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, Generate(4));
        }
        [TestMethod]
        public void ShouldReturnTheSixthLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 5, 10, 10, 5, 1 }, Generate(5));
        }
        private int[] Generate(int n)
        {
            int[] result = new int[n+1];
            if (n == 0)
                return new int[] {1};
            result[0] = 1;
            result[n] = 1;
            int[] penultim = Generate(n-1);
            for (int i = 1; i < n; i++)
            {
                result[i] = penultim[i - 1] + penultim[i];   
            }
            return result;
        }
    }
}
