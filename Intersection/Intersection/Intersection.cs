using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class Intersection
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreNotEqual(new Point(0, 0), new Point(0, 1));
        }
        public struct Point
        {
            int x, y;
            public Point (int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
