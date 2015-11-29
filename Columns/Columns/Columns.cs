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
        string generateColumnName (int number)
        {
            string alfabet = "abcdefghijklmnopqrstuvwxyz";
            int y = 1;
            string column = "";
            while(y != 0)
            {
                int i = (number % 26)-1;
                if (i == -1)
                    i = 25;
                y = number / 26;
                column =alfabet[i] + column;
                number = number - 26 - i;
                if (y==0)
                {
                    return column;
                }
            }
            return "";
        }
    }
}
