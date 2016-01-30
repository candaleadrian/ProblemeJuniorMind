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
        private string[] SortText(string toBeSorted)
        {
            string[] words = toBeSorted.Split(' ');
            if (words.Length <= 1)
                return words;
            return new string[] {};
        }
    }
}
