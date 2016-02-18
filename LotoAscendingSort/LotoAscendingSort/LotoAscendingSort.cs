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
            CollectionAssert.AreEqual(expected, SortNumbersQuickMethod(entry));
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
            int[] entry = { 7, 3, 2, 4, 6, 8, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "Quick"));
        }
        [TestMethod]
        public void ShouldSortEightNumbersWithQuickMethod()
        {
            int[] entry = { 9, 7, 3, 2, 4, 6, 8, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "Quick"));
        }

        [TestMethod]
        public void ShouldSortTwoNumbersWithQuickNotRecMethod()
        {
            int[] entry = { 2, 1 };
            int[] expected = { 1, 2 };
            CollectionAssert.AreEqual(expected, SortNumbersQuickMethodNotRecursive(entry));
        }
        [TestMethod]
        public void ShouldSortThreeNumbersWithQuickNotRecMethod()
        {
            int[] entry = { 4, 2, 3 };
            int[] expected = { 2, 3, 4 };
            CollectionAssert.AreEqual(expected, SortNumbersQuickMethodNotRecursive(entry));
        }
        [TestMethod]
        public void ShouldSortSevenNumbersWithQuickNotRecMethod()
        {
            int[] entry = { 7, 3, 2, 4, 6, 8, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "QuickNotRec"));
        }
        [TestMethod]
        public void ShouldSortEightNumbersWithQuickNotRecMethod()
        {
            int[] entry =    { 9, 7, 3, 2, 4, 6, 8, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "QuickNotRec"));
        }
        [TestMethod]
        public void ShouldSortEightNumbersWithSelectionMethod()
        {
            int[] entry = { 4, 5, 2, 3, 7, 6, 8, 9 };
            int[] expected = { 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "Selection"));
        }
        [TestMethod]
        public void ShouldSortEightNumbersWithBubbleMethod()
        {
            int[] entry =    { 9, 7, 3, 2, 4, 6, 8, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "Bubble"));
        }
        [TestMethod]
        public void ShouldSortEightNumbersWithQuickNotRecursiveMethod()
        {
            int[] entry =    { 9, 7, 3, 2, 4, 8, 6, 1 };
            int[] expected = { 1, 2, 3, 4, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "QuickNotRec"));
        }
        [TestMethod]
        public void ShouldSortTestNumbersWithQuickNotRecuriveMethod()
        {
            int[] entry =    { 9, 7, 3, 2, 4, 1 };
            int[] expected = { 1, 2, 3, 4, 7, 9 };
            CollectionAssert.AreEqual(expected, SortAscending(entry, "QuickNotRec"));
        }
        public int[] SortAscending(int[] numbers,string method)
        {
            switch(method)
            {
                case "Selection":
                    return SortNumbersSelectionMethod(numbers);
                case "Quick":
                    return SortNumbersQuickMethod(numbers);
                case "QuickNotRec":
                    return SortNumbersQuickMethodNotRecursive(numbers);
                case "Bubble":
                    return SortNumbersBubble(numbers);
                default:
                    return new int[] { };
            }
        }

        private int[] SortNumbersBubble(int[] numbers)
        {
            bool swaped = true;
            while (swaped)
            {
                swaped = false;
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        Swap(ref numbers[j], ref numbers[j - 1]);
                        swaped = true;
                    }
                }
            }
            return numbers;
        }

        private int[] SortNumbersQuickMethod(int[] numbers)
        {
            int start = 0;
            int end = numbers.Length - 1;
            SortNumbersQuickMethod(numbers, start, end);
            return numbers;
        }

        public void SortNumbersQuickMethod(int[] numbers, int start, int end)
        {
            if (start <= end)
            {
                Swap(ref numbers[start], ref numbers[new Random().Next(start, end + 1)]);
                int k = start;
                for (int i = start + 1; i <= end; i++)
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
        public struct Ranges
        {
            public int start, end;
            public Ranges(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }
        private int[] SortNumbersQuickMethodNotRecursive(int[] numbers)
        {
            Ranges[] intervals = new Ranges[0];
            int start = 0;
            int end = numbers.Length-1;
            int pivot = 0;
            while (start <end || intervals.Length>0)
            {
                if (start>end)
                {
                    
                    Ranges tempInterval = PopIntervalFromRanges(ref intervals);
                    start = tempInterval.start;
                    end = tempInterval.end;
                    Partition(numbers, start, end);
                }
                pivot = Partition(numbers, start, end);
                if (pivot + 1 < end)
                    PushIntervalToRanges(ref intervals, pivot + 1, end);
                end = pivot - 1;
            }
            return numbers;
        }

        public Ranges PopIntervalFromRanges(ref Ranges[] intervals)
        {
            Ranges interval = intervals[intervals.Length - 1];
            Array.Resize(ref intervals, intervals.Length-1);
            return interval;
        }

        private void PushIntervalToRanges(ref Ranges[] intervals,int pivot, int end)
        {
                Array.Resize(ref intervals, intervals.Length + 1);
                intervals[intervals.Length - 1] = new Ranges(pivot, end);
        }

        private int Partition(int[] numbers, int start, int end)
        {
            int k = start;
            for (int i = start; i <= end; i++)
            {
                if (numbers[start] > numbers[i])
                    Swap(ref numbers[i], ref numbers[++k]);
            }
            Swap(ref numbers[start], ref numbers[k]);
            return k;
        }

        private int[] SortNumbersSelectionMethod(int[] numbers)
        {
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
