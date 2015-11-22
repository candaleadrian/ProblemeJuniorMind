using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentPenalty
{
    [TestClass]
    public class RentPenalty
    {
        [TestMethod]
        public void oneToTenDays()
        {
            Assert.AreEqual(2, calculatePenalty(2, 1));
        }
        decimal calculatePenalty(int rent, int daysDelay)
        {
            return 0;
        }
    }
}
