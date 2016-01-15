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
                CalculateLastPoint(item, ref actual);
                if (CeckForIntersection(actual, points))
                {
                    return actual;
                }
                else
                {
                    AddActualToPoints(ref actual, ref points);
                }
            }
            return start;
        }
        private void AddActualToPoints(ref Point actual, ref Point[] array)
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
         public void CalculateLastPoint(char direction, ref Point actual)
        {
               switch (direction)
                {
                    case 'R':
                        actual = new Point(actual.x + 1, actual.y);
                        break;
                    case 'L':
                        actual = new Point(actual.x - 1, actual.y);
                        break;
                    case 'U':
                        actual = new Point(actual.x, actual.y + 1);
                        break;
                    case 'D':
                        actual = new Point(actual.x, actual.y - 1);
                        break;
                    default:
                        break;
                }            
        }
    }
}
