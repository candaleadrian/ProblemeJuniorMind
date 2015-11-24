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
        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
            int price = distanceInKm < 21 ? 5 : 8;
            return distanceInKm * price ;
        }
    }
}
