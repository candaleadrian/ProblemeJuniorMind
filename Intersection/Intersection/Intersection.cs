using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class Intersection
    {
        [TestMethod]
        public void ShouldPassIfPointsCoordinateAreDifferent()
        {
            Assert.AreNotEqual(new Point(0, 0), new Point(0, 1));
        }
        [TestMethod]
        public void ShouldIncreaseXDirectionWithOne()
        {
            Assert.AreEqual(new Point(1, 0), AddOneToXDirection(new Point(0, 0)));
        }
        public struct Point
        {
            public int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public Point AddOneToXDirection(Point start)
        {
            return new Point(start.x+1,start.y) ;
        }
    }
}
