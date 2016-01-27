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
        private int[] Generate(int n)
        {
            int[] result = new int[n+1];
            if (n == 0)
                return new int[] {1};
            result[0] = 1;
            result[n] = 1;
            return result;
        }
    }
}
