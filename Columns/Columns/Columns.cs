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
        string generateColumnName (int number)
        {
            string alfabet = "abcdefghijklmnopqrstuvwxyz";
            int y = 1;
            string column = "";
            while(y != 0)
            {
                int i = (number % 26)-1;
                y = number / 26;
                column = column + alfabet[i];
                number = number - 26;
                if (y==0)
                {
                    return column;
                }
            }
            return "";
        }
    }
}
