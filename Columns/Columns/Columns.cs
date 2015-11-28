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
                return column;
            }
            return "";
        }
    }
}
