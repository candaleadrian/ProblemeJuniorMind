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
        public void ShouldAddANewValueToTheList()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
            int result = list.Count();
            Assert.AreEqual(1, result);
        }
    }
}
