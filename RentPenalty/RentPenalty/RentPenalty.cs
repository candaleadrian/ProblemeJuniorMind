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
            Assert.AreEqual(102, calculatePenalty(100, 1));
        }
        decimal calculatePenalty(int rent, int daysDelay)
        {
            decimal penalty = rent * 2 / 100;
            return rent + penalty ;
        }
    }
}
