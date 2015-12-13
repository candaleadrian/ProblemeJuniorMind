using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseOperations
{
    [TestClass]
    public class BaseOperations
    {
        [TestMethod]
        public void Transform1FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new int[] { 1 },Transform1FromBase10ToBase2(1));
        }
        [TestMethod]
        public void Transform2FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new int[] { 1 , 0 }, Transform1FromBase10ToBase2(2));
        }

        int[] Transform1FromBase10ToBase2(int number)
        {    
            int[] base2Array = {};
            while (number > 0)
            {
            Array.Resize(ref base2Array, base2Array.Length + 1);
            base2Array[base2Array.Length-1] = number % 2;
                number = number / 2;
            }
            return InvertArray(base2Array);
        }
        //[TestMethod]
        //public void InvertArray123()
        //{
        //    CollectionAssert.AreEqual(new int[] { 3,2,1 },InvertArray({1,2,3}));
        //}

        public int[] InvertArray(int[] array)
        {
            int[] invertedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                invertedArray[i] = array[array.Length-1-i];
            }
            return invertedArray;
        }
    }
}
