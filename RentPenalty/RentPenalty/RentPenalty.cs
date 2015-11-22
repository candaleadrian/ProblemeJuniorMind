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
        [TestMethod]
        public void oneToTenDays7()
        {
            Assert.AreEqual(114, calculatePenalty(100, 7));
        }
        [TestMethod]
        public void tenToThirtyDays11()
        {
            Assert.AreEqual(155, calculatePenalty(100, 11));
        }
        [TestMethod]
        public void ThirtyToFourtyDays31()
        {
            Assert.AreEqual(410, calculatePenalty(100, 31));
        }
        decimal calculatePenalty(int rent, int daysDelay)
        {
            decimal penalty = rent * penaltyPercent(daysDelay) / 100;
            return rent + penalty * daysDelay;
        }

        private static decimal penaltyPercent(int daysDelay)
        {
            return daysDelay <= 10 ? 2 : daysDelay <= 30 ? 5 : 10;
        }
    }
}
