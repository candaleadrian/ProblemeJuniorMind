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
        [TestMethod]
        public void SquareEdge2()
        {
            Assert.AreEqual(5, countSquaresNumber(2));
        }
        [TestMethod]
        public void SquareEdge8()
        {
            Assert.AreEqual(204, countSquaresNumber(8));
        }
        int countSquaresNumber(int squareEdge)
        {
            return squareEdge * (squareEdge +1)*(2*squareEdge +1)/6;
        }
    }
}
