﻿using System;
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
            CollectionAssert.AreEqual(new int[] {1,1}, BitOperarion(TransformFromBaseTenToBaseTwo(1),TransformFromBaseTenToBaseTwo(2),"OR"));
        }
        [TestMethod]
        public void OROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1,1,1 }, BitOperarion(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "OR"));
        }
        [TestMethod]
        public void ANDOperation()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0 }, BitOperarion(TransformFromBaseTenToBaseTwo(1), TransformFromBaseTenToBaseTwo(2), "AND"));
        }
        [TestMethod]
        public void ANDOperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, BitOperarion(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "AND"));
        }
        [TestMethod]
        public void XOROperation()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1 }, BitOperarion(TransformFromBaseTenToBaseTwo(1), TransformFromBaseTenToBaseTwo(2), "XOR"));
        }
        [TestMethod]
        public void XOROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1, 1, 0 }, BitOperarion(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "XOR"));
        }

        public int[] BitOperarion(int[] v1, int[] v2, string Operation)
        {
            int orArrayLength = Math.Max(v1.Length, v2.Length);
            if (v1.Length > v2.Length)
            {
                v2 = AddZeroValuesToArrayUntilSpecifiedLength(v2, v1.Length);
            }
            if (v1.Length < v2.Length)
            {
                v1 = AddZeroValuesToArrayUntilSpecifiedLength(v1, v2.Length);
            }
            int[] orResult = new int[orArrayLength];
            for (int i = 0; i < orArrayLength; i++)
            {
                if (Operation == "OR")
                {
                    if (v1[i] == 1 || v2[i] == 1)
                    {
                        orResult[i] = 1;
                    }
                    else
                        orResult[i] = 0;
                }
                if (Operation == "AND")
                {
                    if (v1[i] == 1 && v2[i] == 1)
                    {
                        orResult[i] = 1;
                    }
                    else
                        orResult[i] = 0;
                }
                if (Operation == "XOR")
                {
                    if (v1[i] == v2[i])                    
                        orResult[i] = 0;
                    else
                        orResult[i] = 1;
                }
            }
            return orResult;
        }
        [TestMethod]
        public void NOTOperation()
        {
            CollectionAssert.AreEqual(new int[] { 1,1,1,1,1,1,0, 1 }, NotOperation(TransformFromBaseTenToBaseTwo(2)));
        }
        int[] NotOperation(int[] notArray)
        {
            return new int[] { };
        }

        [TestMethod]
        public void AddZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new int[] { 1}, 2 ));
        }
        [TestMethod]
        public void AddFiveZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new int[] { 0,0,0,0,0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new int[] { 1 }, 6));
        }

        private int[] AddZeroValuesToArrayUntilSpecifiedLength(int[] arrayToModify, int arrayDesiredLength)
        {
            int[] invertedArray = InvertArray(arrayToModify);
            while (invertedArray.Length < arrayDesiredLength)
            {
                Array.Resize(ref invertedArray, invertedArray.Length + 1);
                invertedArray[invertedArray.Length - 1] = 0;
            }
            return InvertArray(invertedArray);
        }
    }
}