using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shoping
{
    [TestClass]
    public class Shoping
    {
        [TestMethod]
        public void ShouldCalculateTotalForOneProduct()
        {
            Assert.AreEqual(40.5M, CalculateTotal());
        }        
        enum products { milk=1550, water = 2500};    
        decimal CalculateTotal()
        {
            decimal totalPurchases = 0;
            foreach (products item in Enum.GetValues(typeof(products)))
            {
                totalPurchases += (decimal) item;
            }
            return (decimal) totalPurchases/100;
        }
    }
}
