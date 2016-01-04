using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shoping
{
    [TestClass]
    public class Shopping
    {
        [TestMethod]
        public void TestShoppingCartFirstProductName()
        {
            Assert.AreEqual("milk", shoppingCart[0].productName);
        }
        [TestMethod]
        public void TestShoppingCartFirstProductPrice()
        {
            Assert.AreEqual(15.50M, shoppingCart[0].price);
        }
        [TestMethod]
        public void ShouldReturnTotalForAllShoppingCartProduct()
        {
            Assert.AreEqual(48.25M, CalculateTotalPurchase());
        }
        [TestMethod]
        public void ShouldReturnShoppingCartFirstProductPrice()
        {
            Assert.AreEqual(15.50M, GetEachPrice(0));
        }
        [TestMethod]
        public void ShouldReturnShoppingCartCheapestProductPrice()
        {
            Assert.AreEqual("water", FindTheCheapestProduct());
        }
        string FindTheCheapestProduct()
        {
            int counter = 0;    
            for (int i = 0; i < shoppingCart.Length-1; i++)
            {
                counter = GetEachPrice(i) < GetEachPrice(i + 1) ? i : i + 1;
            }
            return shoppingCart[counter].productName;
        }
        decimal CalculateTotalPurchase()
        {
            decimal sum = 0;       
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                sum += GetEachPrice(i);
            }
            return sum;
        }
        decimal GetEachPrice(int i)
        {
            return shoppingCart[i].price;
        }
        public struct ProductNameAndPrice
        {
            public string productName;
            public decimal price;            
        }
        public ProductNameAndPrice[] shoppingCart = 
          {
            new ProductNameAndPrice { productName = "milk", price = 15.50M},
            new ProductNameAndPrice { productName = "beer", price = 21.42M},
            new ProductNameAndPrice { productName = "water", price = 11.33M}
          };
    }
}
