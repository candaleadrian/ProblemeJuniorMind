using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class HanoiTowers
    {
        [TestMethod]
        public void ShouldReturnTheMoveForOneDisc()
        {
            CollectionAssert.AreEqual( { new Step('A', 'C')} Solution(1));
        }
        public Step[] Solution(int n)
        {
            Step[] steps = { new Step('A', 'C') };
            return steps;
        }
        public struct Step
        {
            public char x, y;
            public Step (char x,char y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
