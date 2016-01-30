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
        [TestMethod]
        public void ShouldReturnTrueForTwoSortedWords()
        {
            Assert.IsTrue(Sorted("abc","abd"));
        }
        [TestMethod]
        public void ShouldReturnFalseForTwoUnortedWords()
        {
            Assert.IsFalse(Sorted("abc", "aad"));
        }
        [TestMethod]
        public void ShouldSortWordForTwoWordsText()
        {
            string[] expected = { "aab", "abc" };
            CollectionAssert.AreEqual(expected, SortText("abc aab"));
        }
        private string[] SortText(string toBeSorted)
        {
            string[] words = toBeSorted.Split(' ');
            if (words.Length <= 1)
                return words;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (!Sorted(words[i],words[j]))
                        return new string[] { };
                }
            }
            return new string[] {};
        }
        private bool Sorted(string first, string second)
        {
            for (int i = 0; i < Math.Max(first.Length,second.Length); i++)
            {
                if (first[i]>second[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
