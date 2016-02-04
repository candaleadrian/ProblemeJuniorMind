using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrioritySort
{
    [TestClass]
    public class PrioritySort
    {
        [TestMethod]
        public void SouldReturnAStructOrderdByPriority()
        {
            var expected = new Repairs[] { new Repairs("shoping", "High") };
            var result =SortByPriority(new Repairs[] { new Repairs("shoping", "High") });
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SouldReturnZeroForRepairWithHighPrio()
        {
            var repair = new Repairs("shoping", "High");
            Assert.AreEqual(0,CheckPriority(repair));
        }
        [TestMethod]
        public void SouldReturnOneForRepairWithMediumPrio()
        {
            var repair = new Repairs("shoping", "Medium");
            Assert.AreEqual(1, CheckPriority(repair));
        }
        [TestMethod]
        public void SouldSwapAStructOfTwoByPriority()
        {
            Repairs[] repairs = new Repairs[]
            {
             new Repairs("work", "Medium"),
             new Repairs("shoping", "High")
            };
            Repairs[] expected = new Repairs[]
            {
             new Repairs("shoping", "High"),
             new Repairs("work", "Medium")
            };
            CollectionAssert.AreEqual(expected,SortByPriority(repairs));
        }
        public string[] Prio = { "High" , "Medium" , "Low" };
        public Repairs[] SortByPriority(Repairs[] ToBeSorted)
        {
            for (int i = 0; i < ToBeSorted.Length; i++)
            {
                for (int j = i; j < ToBeSorted.Length-1; j++)
                {
                    if (CheckPriority(ToBeSorted[j]) > CheckPriority(ToBeSorted[j+1]))
                    {
                        Swap(ref ToBeSorted,j);
                    }
                }
            }
            return ToBeSorted;
        }

        private void Swap(ref Repairs[] toBeSorted, int pos)
        {
            Repairs temp = toBeSorted[pos];
            toBeSorted[pos] = toBeSorted[pos+1];
            toBeSorted[pos + 1] = temp;
        }

        private int CheckPriority(Repairs toBeSorted)
        {
            return Array.FindIndex(Prio,priority => priority.Contains (toBeSorted.priority));
        }

        public struct Repairs
        {
            public string repair;
            public string priority;
            public Repairs(string repair, string priority)
            {
                this.repair = repair;
                this.priority = priority;
            }
        }
    }
}
