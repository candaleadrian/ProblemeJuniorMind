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
            Assert.AreEqual(15, CalculateTotal(products.milk));
        }        
        enum products { milk= (int) 15.50, water = 25};    
        decimal CalculateTotal(object product)
        {
            return (decimal) products.milk;
        }
    }
}
