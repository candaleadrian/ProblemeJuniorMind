using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoAscendingSort
{
    [TestClass]
    public class LotoAscendingSort
    {
        [TestMethod]
        public void ShouldReturnTheSameArrayForOneNumber()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, SortAscending(new int[] { 1 }));
        }
        [TestMethod]
        public void ShouldSortAscendingTwoElementsrray()
        {
            CollectionAssert.AreEqual(new int[] { 1,2 }, SortAscending(new int[] { 2,1 }));
        }
        [TestMethod]
        public void ShouldSwapTheNumbers()
        {
            int[] entry = { 2,1};
            Swap(ref entry[0], ref entry[1]);
            int[] result = { 1,2};
            CollectionAssert.AreEqual(result,entry);
        }
        public int[] SortAscending(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            if (numbers.Length <= 1)
                return numbers;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                        Swap(ref numbers[i],ref numbers[j]);
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
