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

        private int[] Generate(int n)
        {
            if (n == 0)
                return new int[] { 1 };
            return new int[] {};
        }
    }
}
