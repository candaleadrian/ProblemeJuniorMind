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
            
        }
        public struct Repairs
        {
            public string repair, priority;
            public Repairs(string repair, string priority)
            {
                this.repair = repair;
                this.priority = priority;
            }
        }
        public object[] repairs =
            {
            new Repairs ("Radio", "High"),
            new Repairs ("Book", "Medium"),
            new Repairs ("Tv", "Low"),
            new Repairs ("Car", "High"),
            };         
    }
}
