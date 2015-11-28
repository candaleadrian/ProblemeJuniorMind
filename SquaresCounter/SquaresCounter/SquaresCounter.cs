using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquaresCounter
{
    [TestClass]
    public class SquaresCounter
    {
        [TestMethod]
        public void SquareEdge1()
        {
            Assert.AreEqual(1, countSquaresNumber(1));
        }
        int countSquaresNumber(int squareEdge)
        {
            return 0;
        }
    }
}
