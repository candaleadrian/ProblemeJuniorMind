﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoAscendingSort
{
    [TestClass]
    public class LotoAscendingSort
    {
        [TestMethod]
        public void ShouldReturnTheSameArrayForOneNumber()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, SortAscending(new int[] { 1 }, "Selection"));
        }
        [TestMethod]
        public void ShouldSortAscendingTwoElementsArray()
        {
            CollectionAssert.AreEqual(new int[] { 1,2 }, SortAscending(new int[] { 2,1 }, "Selection"));
        }
        [TestMethod]
        public void ShouldSwapTheNumbers()
        {
            int[] entry = { 2,1};
            Swap(ref entry[0], ref entry[1]);
            int[] result = { 1,2};
            CollectionAssert.AreEqual(result,entry);
        }
        [TestMethod]
        public void ShouldSortAscendingFiveElementsArray()
        {
            CollectionAssert.AreEqual(new int[] { 13, 26, 32, 42, 78 }, SortAscending(new int[] { 32,13,42,26,78 }, "Selection"));
        }
        [TestMethod]
        public void ShouldSortTwoNumbersWithQuickMethod()
        {
            int[] entry = { 2, 1 };
            int[] expected = { 1, 2 };
            CollectionAssert.AreEqual(expected,SortNumbersQuickMethod(entry));
        }
        [TestMethod]
        public void ShouldSortThreeNumbersWithQuickMethod()
        {
            int[] entry = { 4, 2, 3 };
            int[] expected = { 2, 3, 4 };
            CollectionAssert.AreEqual(expected, SortNumbersQuickMethod(entry));
        }
        [TestMethod]
        public void ShouldSortSevenNumbersWithQuickMethod()
        {
            int[] entry = { 7, 3, 2,4,6,8,5 };
            int[] expected = { 2, 3, 4,5,6,7,8 };
            CollectionAssert.AreEqual(expected, SortAscending(entry,"Quick"));
        }
        [TestMethod]
        public void ShouldSortEightNumbersWithQuickMethod()
        {
            int[] entry = { 9, 7, 3, 2, 4, 6, 8, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "Quick"));
        }
        public int[] SortAscending(int[] numbers,string method)
        {
            switch(method)
            {
                case "Selection":
                    return SortNumbersSelectionMethod(numbers);
                case "Quick":
                    return SortNumbersQuickMethod(numbers);
                default:
                    return new int[] { };
            }
        }
        private int[] SortNumbersQuickMethod(int[] numbers)
        {
            int start = 0;
            int end = numbers.Length-1;
            SortNumbersQuickMethod(numbers, start, end);
            return numbers;
        }

        public void SortNumbersQuickMethod(int[] numbers, int start, int end)
        {
            if (start <= end)
            {
                Swap(ref numbers[start], ref numbers[new Random().Next(start, end+1)]);
                int k = start;
                for (int i = start+1; i <= end; i++)
                {
                    if (numbers[start] > numbers[i])
                        Swap(ref numbers[i], ref numbers[++k]);
                }
                Swap(ref numbers[start], ref numbers[k]);
                if (start <= k - 1)
                    SortNumbersQuickMethod(numbers, start, k - 1);
                if (k + 1 < end)
                    SortNumbersQuickMethod(numbers, k + 1, end);
            }
        }

        //private int[] SortNumbersQuickMethod(int[] numbers)
        //{
        //    int k=1;
        //    while (k != 0)
        //    {
        //        k = 0;
        //        for (int i = 1; i < numbers.Length; i++)
        //        {
        //            if (numbers[0] > numbers[i])
        //                Swap(ref numbers[i], ref numbers[++k]);
        //        }
        //        Swap(ref numbers[0], ref numbers[k]);
        //    }
        //        return numbers;
        //}

        private int[] SortNumbersSelectionMethod(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            if (numbers.Length <= 1)
                return numbers;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                        Swap(ref numbers[i], ref numbers[j]);
                }
            }
            return numbers;
        }

        private void Swap(ref int bigger,ref int smaller)
        {
            int temp = bigger;
            bigger = smaller;
            smaller = temp;
        }
    }
}
