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
            Assert.AreEqual(new Point(0, 0), ReturnTheFirsIntersectionPoint("R"));
        }
        [TestMethod]
        public void ShouldIncreaseAndDecreaseXDirectionWithOneWithAStringComand()
        {
            Assert.AreEqual(new Point(0, 0), ReturnTheFirsIntersectionPoint("RL"));
        }
        [TestMethod]
        public void ShouldDecreaseXDirectionWithOne()
        {
            Assert.AreEqual(new Point(-1, 0), SubstractOneToXDirection(new Point(0, 0)));
        }
        [TestMethod]
        public void ShouldIncreaseYDirectionWithOne()
        {
            Assert.AreEqual(new Point(0, 1), AddOneToYDirection(new Point(0, 0)));
        }
        [TestMethod]
        public void ShouldDecreaseYDirectionWithOne()
        {
            Assert.AreEqual(new Point(0, -1), SubstractOneToYDirection(new Point(0, 0)));
        }
        [TestMethod]
        public void ShouldCalculateFirstIntersectionBasedOnStringUURDL()
        {
            Assert.AreEqual(new Point(0, 1), ReturnTheFirsIntersectionPoint("UURDL"));
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
            foreach (char item in path)
            {
                CalculateLastPoint(item, actual);
                if (CeckForIntersection(actual, points))
                {
                    return actual;
                }
                else
                {
                    AddActualToPoints(actual, points);
                }
            }
            return start;
        }
        private void AddActualToPoints(Point actual, Point[] array)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length - 1] = actual;
        }
        private bool CeckForIntersection(Point actual, Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (actual.x == points[i].x && actual.y == points[i].y)
                    return true;
            }
            return false;
        }
         public void CalculateLastPoint(char direction, Point actual)
        {
               switch (direction)
                {
                    case 'R':
                        actual = AddOneToXDirection(actual);
                        break;
                    case 'L':
                        actual = SubstractOneToXDirection(actual);
                        break;
                    case 'U':
                        actual = AddOneToYDirection(actual);
                        break;
                    case 'D':
                        actual = SubstractOneToYDirection(actual);
                        break;
                    default:
                        break;
                }            
        }
        public Point AddOneToXDirection(Point coord)
        {
            return new Point(coord.x+1,coord.y) ;
        }
        public Point SubstractOneToXDirection(Point coord)
        {
            return new Point(coord.x - 1, coord.y);
        }
        public Point AddOneToYDirection(Point coord)
        {
            return new Point(coord.x, coord.y + 1);
        }
        public Point SubstractOneToYDirection(Point coord)
        {
            return new Point(coord.x, coord.y - 1);
        }
    }
}
