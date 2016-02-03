using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortWords
{
    [TestClass]
    public class SortWords
    {
        [TestMethod]
        public void ShouldReturnWordForOneWordText()
        {
           CollectionAssert.AreEqual(new string[] {"abc"}, SortText("abc"));
        }
        public string[] SortText(string textToSort)
        {
            string[] textArray = textToSort.Split(' ');
            return textArray;
        }
    }
}
