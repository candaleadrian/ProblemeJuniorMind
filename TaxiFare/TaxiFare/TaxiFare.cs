using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiFare
{
    [TestClass]
    public class TaxiFare
    {
        [TestMethod]
        public void TestDayFareShortDistance()
        {
            Assert.AreEqual(5, CalculateTaxiFare(1, 8));
        }
        [TestMethod]
        public void TestDayFareMediumDistance()
        {
            Assert.AreEqual(168, CalculateTaxiFare(21, 8));
        }
        [TestMethod]
        public void TestDayFareLongDistance()
        {
            Assert.AreEqual(366, CalculateTaxiFare(61, 8));
        }
        [TestMethod]
        public void TestNightFareShortDistance()
        {
            Assert.AreEqual(7, CalculateTaxiFare(1, 21));
        }
        [TestMethod]
        public void TestNightFareMediumDistance()
        {
            Assert.AreEqual(210, CalculateTaxiFare(21, 21));
        }
        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
            return distanceInKm * TripTipeFare (distanceInKm , hour );
        }
        private static decimal  TripTipeFare(int distanceInKm, int hour)
        {
            decimal [] dayPrice = { 5, 8, 6 };
            decimal [] nightPrice = { 7, 10 };
            decimal [] price = 8 <= hour && hour < 21 ? dayPrice : nightPrice;
            if (distanceInKm < 21)
                return price[0];
            if (distanceInKm < 61)
                return price[1];
            return price[2];
        }
    }
}
