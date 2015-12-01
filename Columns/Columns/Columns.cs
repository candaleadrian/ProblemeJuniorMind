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
            Assert.AreEqual("a",generateColumnName (1));
        }

        [TestMethod]
        public void ColumnP()
        {
            Assert.AreEqual("p", generateColumnName(16));
        }
        [TestMethod]
        public void ColumnAA()
        {
            Assert.AreEqual("aa", generateColumnName(27));
        }
        [TestMethod]
        public void ColumnAB()
        {
            Assert.AreEqual("ab", generateColumnName(28));
        }
        [TestMethod]
        public void ColumnAZ()
        {
            Assert.AreEqual("az", generateColumnName(52));
        }
        [TestMethod]
        public void ColumnBA()
        {
            Assert.AreEqual("ba", generateColumnName(53));
        }
        [TestMethod]
        public void ColumnBB()
        {
            Assert.AreEqual("bb", generateColumnName(54));
        }
        [TestMethod]
        public void ColumnBZ()
        {
            Assert.AreEqual("bz", generateColumnName(78));
        }
        [TestMethod]
        public void ColumnCA()
        {
            Assert.AreEqual("ca", generateColumnName(79));
        }
        [TestMethod]
        public void ColumnAAA()
        {
            Assert.AreEqual("aaa", generateColumnName(703));
        }
        string generateColumnName (int number)
        {
            string alfabet = "abcdefghijklmnopqrstuvwxyz";
            string column = "";
            while(number > 0)
            {
                int i = ((number-1) % 26);
                if (number < 26)
                { 
                    column =  alfabet[i] + column;
                    return column;
                }
                number = number - i;
                column = alfabet[i] + column;
               // number = number - 26;
                if (number / 26 < 26 && number / 26 > 0)
                {
                    i = (number-1) / 26;
                    column = alfabet[i] + column;
                    return column;
                }
            }
            return "";
        }
    }
}
