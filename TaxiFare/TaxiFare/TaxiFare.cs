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
        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
            int price = TripTipeFare(distanceInKm);
            return distanceInKm * price;
        }

        private static int TripTipeFare(int distanceInKm)
        {
            if (distanceInKm < 21)
                return 5;
            if (distanceInKm < 61)
                return 8;
            return 6;
        }
    }
}
