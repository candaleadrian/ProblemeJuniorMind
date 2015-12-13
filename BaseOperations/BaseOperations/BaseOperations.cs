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
            CollectionAssert.AreEqual(new int[] { 1 },TransformFromBaseTenToBaseTwo(1));
        }
        [TestMethod]
        public void Transform2FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new int[] { 1 , 0 }, TransformFromBaseTenToBaseTwo(2));
        }
        [TestMethod]
        public void Transform15FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new int[] { 1, 0,0,0,0 }, TransformFromBaseTenToBaseTwo(16));
        }

        int[] TransformFromBaseTenToBaseTwo(int number)
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
        [TestMethod]
        public void InvertArray123()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, InvertArray(new int[] { 1,2,3}));
        }

        public int[] InvertArray(int[] array)
        {
            int[] invertedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                invertedArray[i] = array[array.Length-1-i];
            }
            return invertedArray;
        }
        [TestMethod]
        public void OROperation()
        {
            CollectionAssert.AreEqual(new int[] {1,1}, ORBitOperarion(TransformFromBaseTenToBaseTwo(1),TransformFromBaseTenToBaseTwo(2)));
        }

        public int[] ORBitOperarion(int[] v1, int[] v2)
        {
            int arrayLength = Math.Max(v1.Length, v2.Length);
            for (int i = 0; i < arrayLength; i++)
            {

            }
            return new int[] {};
        }
        [TestMethod]
        public void AddZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new int[] { 1}, 2 ));
        }

        private int[] AddZeroValuesToArrayUntilSpecifiedLength(object arrayToModify, int arrayDesiredLength)
        {
            return new int[] {};
        }
    }
}
