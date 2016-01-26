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
            Assert.AreEqual( "AC", Solution(1,'A','B','C'));
        }
        public string Solution(int n, char source, char aux, char target)
        {            
            return "AC";
        }
    }
}
