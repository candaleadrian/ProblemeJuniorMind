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
            var repair = new Repairs[] { new Repairs("shoping", "High") };
            Assert.AreEqual(0,CheckPriority(repair,0));
        }
        [TestMethod]
        public void SouldReturnOneForRepairWithMediumPrio()
        {
            var repair = new Repairs[] { new Repairs("shoping", "Medium") };
            Assert.AreEqual(1, CheckPriority(repair, 0));
        }
        public string[] Prio = { "High" , "Medium" , "Low" };
        public Repairs[] SortByPriority(Repairs[] ToBeSorted)
        {
            for (int i = 0; i < ToBeSorted.Length; i++)
            {
                for (int j = i; j < ToBeSorted.Length-1; j++)
                {
                    if (CheckPriority(ToBeSorted,j) > CheckPriority(ToBeSorted,j+1))
                    {

                    }
                }
            }
            return ToBeSorted;
        }

        private int CheckPriority(Repairs[] toBeSorted, int j)
        {
            return Array.FindIndex(Prio,priority => priority.Contains (toBeSorted[j].priority));
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
