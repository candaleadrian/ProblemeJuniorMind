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
            var expected = new Repairs[] { new Repairs("shoping", 1) };
            var result =SortByPriority(new Repairs[] { new Repairs("shoping", 1) });
            CollectionAssert.AreEqual(expected, result);
        }
        public enum Prio { High , Medium , Low };
        public Repairs[] SortByPriority(Repairs[] ToBeSorted)
        {
            var x =  Prio.Medium;
            return new Repairs[] { new Repairs("shoping", x)};
        }
        
        public struct Repairs
        {
            public string repair;
            public var priority;
            public Repairs(string repair, var priority)
            {
                this.repair = repair;
                this.priority = priority;
            }
        }
    }
}
