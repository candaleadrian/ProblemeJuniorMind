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
    }
}
