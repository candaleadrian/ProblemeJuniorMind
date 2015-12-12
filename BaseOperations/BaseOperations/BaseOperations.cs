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

        int[] Transform1FromBase10ToBase2(int number)
        {
            int[] base2Array = { 1 };
            return base2Array;
        }
    }
}
