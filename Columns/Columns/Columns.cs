using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Columns
{
    [TestClass]
    public class Columns
    {
        [TestMethod]
        public void ColumnA()
        {
            Assert.AreEqual("A",generateColumnName (1));
        }
        string generateColumnName (int number)
        {
            return "";
        }
    }
}
