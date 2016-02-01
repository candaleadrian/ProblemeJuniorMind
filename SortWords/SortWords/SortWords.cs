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
        public void ShouldSwapTheWords()
        {
            string[] entry = { "aab", "bbc" };
            Swap(ref entry[0], ref entry[1]);
            string[] result = { "bbc", "aab" };
            CollectionAssert.AreEqual(result, entry);
        }
        [TestMethod]
        public void ShouldSortWordForTwoWordsText()
        {
            string[] expected = { "aab", "abc" };
            CollectionAssert.AreEqual(expected, SortText("abc aab"));
        }
        [TestMethod]
        public void ShouldSortWordsForFiveWordsText()
        {
            string[] expected = { "aab", "abc", "Abc", "abca", "abcd" };
            CollectionAssert.AreEqual(expected, SortText("abc abcd aab Abc abca"));
        }
        private string[] SortText(string toBeSorted)
        {
            string[] words = toBeSorted.Split(' ');
            //if (words.Length <= 1)
            //    return words;
            Array.Sort(words, (x, y) => x.CompareTo(y));
            //for (int i = 0; i < words.Length; i++)
            //{
            //    for (int j = i+1; j < words.Length; j++)
            //    {
            //        if (!Sorted(words[i],words[j]))
            //            Swap(ref words[i],ref words[j]);
            //    }
            //}
            return words;
        }
        private void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }
        private bool Sorted(string first, string second)
        {
            for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
            {
                if (first[i]>second[i])
                {
                    return false;
                }
            }
            return (first.Length<=second.Length)? true: false;
        }
    }
}
