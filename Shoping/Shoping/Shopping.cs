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
            Assert.AreEqual("milk", shoppingCart[0].name);
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
        [TestMethod]
        public void ShouldFindInShoppingCartTheMostExpensiveProductPrice()
        {
            Assert.AreEqual("beer", FindTheMostExpensiveProductAndRemoveItFromCart());
        }
        [TestMethod]
        public void ShouldReturnTotalForAllShoppingCartProductAfterRemovingTheMostExpensive()
        {
            FindTheMostExpensiveProductAndRemoveItFromCart();
            Assert.AreEqual(26.83M, CalculateTotalPurchase());
        }
        [TestMethod]
        public void TestShoppingCartSecondProductName()
        {
            Assert.AreEqual("beer", shoppingCart[1].name);
        }
        [TestMethod]
        public void ShouldReturnTheLastProductInShoppingCart()
        {
            FindTheMostExpensiveProductAndRemoveItFromCart();
            AddOneMoreProductToSoppingCart("wine",85.42M);
            Assert.AreEqual("wine", shoppingCart[2].name);
            Assert.AreEqual(85.42M, shoppingCart[2].price);
        }
        [TestMethod]
        public void TestTheAveragePriceForItemsInCart()
        {
            FindTheMostExpensiveProductAndRemoveItFromCart();
            AddOneMoreProductToSoppingCart("wine", 85.42M);
            Assert.AreEqual(37.42M, CalculateAveragePrice());
        }
        decimal CalculateAveragePrice()
        {
            return Math.Round (CalculateTotalPurchase() / shoppingCart.Length,2);
        }
        public void AddOneMoreProductToSoppingCart(string name, decimal price)
        {
            Array.Resize(ref shoppingCart, shoppingCart.Length+1);
           shoppingCart[shoppingCart.Length-1].name = name;
            shoppingCart[shoppingCart.Length - 1].price = price;
        }
        string FindTheMostExpensiveProductAndRemoveItFromCart()
        {
            int counter = 0;
            decimal max = GetEachPrice(0);
            for (int i = 0; i < shoppingCart.Length-1; i++)
            {
                if (GetEachPrice(i)>max)
                {
                    max = GetEachPrice(i);
                    counter = i;
                }
            }
            string result = shoppingCart[counter].name;
            RemoveDesiredProduct(counter);
            return result;
        }
        public void RemoveDesiredProduct(int position)
        {
            for (int i = position; i < shoppingCart.Length-1; i++)
            {
                shoppingCart[i] = shoppingCart[i + 1];
            }
            Array.Resize(ref shoppingCart, shoppingCart.Length - 1);
        }
        string FindTheCheapestProduct()
        {
            int counter = 0;
            decimal min = GetEachPrice(0);
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                if (GetEachPrice(i) < min)
                {
                    min = GetEachPrice(i);
                    counter = i;
                }
            }
            return shoppingCart[counter].name;
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
        public struct Product
        {
            public string name;
            public decimal price;            
        }
        public Product[] shoppingCart = 
          {
            new Product { name = "milk", price = 15.50M},
            new Product { name = "beer", price = 21.42M},
            new Product { name = "water", price = 11.33M}
          };
    }
}
