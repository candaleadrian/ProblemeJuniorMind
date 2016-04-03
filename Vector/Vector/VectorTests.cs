using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace Vector
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void ShouldCountTheNumberOfElementsForOneElement()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            int result = list.Count();
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void ShouldCountTheNumberOfElementsForOneStringElement()
        {
            VectorClass<string> list = new VectorClass<string>();
            list.Add("something");
            int result = list.Count();
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void ShouldCountTheNumberOfElementsForTwoElement()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            int result = list.Count();
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void ShouldTestIfClearWorks()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Clear();
            int result = list.Count();
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void ShouldTestIfListContainsNumberTwo()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Clear();
            bool result = list.Contains(2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ShouldTestCopyToIfAdsValuesToArray()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            int[] toAdd = new int[2];
            list.CopyTo(toAdd, 0);
            Assert.AreEqual(1, toAdd[0]);
        }
        [TestMethod]
        public void ShouldTestCopyToIfAdsValuesToArrayStartingFromSecondElement()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] toAdd = new int[2];
            list.CopyTo(toAdd, 1);
            Assert.AreEqual(3, toAdd[1]);
        }
        [TestMethod]
        public void ShouldReturnIndexForElementTwo()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int result = list.IndexOf(2);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void ShouldReturnMinusOneIfElementIsNotContained()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int result = list.IndexOf(4);
            Assert.AreEqual(-1, result);
        }
        [TestMethod]
        public void ShouldInsertNewElementInList()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 7);
            int result = list.IndexOf(7);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void ShouldRemoveElementAtIndexOneInList()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 7);
            list.RemoveAt(1);
            int result = list.IndexOf(7);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void ShouldRemoveElementWithValueTwoInList()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 7);
            list.Remove(2);
            int result = list.IndexOf(7);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void ShouldReturnTrueIfCounterMovedNext()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 7);
            var result = list.Current;
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void ShouldReturnFirstElementInList()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 7);
            var result = list.Current;
            Assert.AreEqual(1, result);
        }
    }
}
