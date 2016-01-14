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
        [TestMethod]
        public void ShouldIncreaseXDirectionWithOneWithAStringComand()
        {
            Assert.AreEqual(new Point(1, 0), ReturnTheFirsIntersectionPoint("U"));
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
        // path should be given with a strind D=Doun, U=Up, L=Left, R=Right
        public Point ReturnTheFirsIntersectionPoint(string path)
        {
            Point start = new Point(0, 0);
            Point[] points = { start};
            Point actual = points[points.Length - 1];
            foreach (char direction in path)
            {
                switch (direction)
                {
                    case 'U':
                        actual = AddOneToXDirection(actual);
                        break;
                    default:
                        break;
                }
            }
            return actual;
        }
        public Point AddOneToXDirection(Point coord)
        {
            return new Point(coord.x+1,coord.y) ;
        }
    }
}
