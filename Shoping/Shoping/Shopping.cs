using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shoping
{
    [TestClass]
    public class Shopping
    {
        [TestMethod]
        public void ShouldCalculateTotalForOneProduct()
        {
            Assert.AreEqual(96M, CalculateTotal());
        }
        [TestMethod]
        public void TestShoppingCart()
        {
            Assert.AreEqual("milk", shoppingCart[0].productName);
        }
        public struct ProductNameAndPrice
        {
            public string productName;
            public decimal price;            
        }
        public ProductNameAndPrice[] shoppingCart = 
          {
            new ProductNameAndPrice { productName = "milk", price = 15.50M}

          };
        enum products { milk=1550, water = 2500, bear = 5550};    
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
