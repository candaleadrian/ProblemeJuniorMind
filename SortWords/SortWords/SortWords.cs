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
           var structArray = new WordCount[] { new WordCount("abc", 1) };
           CollectionAssert.AreEqual(structArray, SortText("abc"));
        }
        [TestMethod]
        public void ShouldReturnNegativeIfStructDoesntContainWord()
        {
            var structArray = new WordCount[] { new WordCount("abc", 1) };
            var result = ReturnPositionOrNegative(structArray, "bbc");
            Assert.AreEqual(-1,result);
        }
        [TestMethod]
        public void ShouldReturnPositionIfStructContainWord()
        {
            var structArray = new WordCount[] { new WordCount("abc", 1) };
            var result = ReturnPositionOrNegative(structArray, "abc");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void ShouldReturnOneIfStructContainWordOnPositionOne()
        {
            var structArray = new WordCount[] { new WordCount("bbc", 1), new WordCount("abc", 1) };
            var result = ReturnPositionOrNegative(structArray, "abc");
            Assert.AreEqual(1, result);
        }
        public WordCount[] SortText(string textToSort)
        {
            string[] textArray = textToSort.Split(' ');
            var wordCount = new WordCount[textArray.Length];
            for (int i = 0; i < textArray.Length; i++)
            {
                int length = 0;
                int pos = ReturnPositionOrNegative(wordCount,textArray[i]);
                if (pos < 0)
                {
                    wordCount[length].word = textArray[i];
                    length++;
                }
                else
                    wordCount[pos].number++;       
            }
            return wordCount;
        }

        private int ReturnPositionOrNegative(WordCount[] wordCount, string word)
        {
            for (int i = 0; i < wordCount.Length; i++)
            {
                if (wordCount[i].word == word)
                    return i;                
            }
            return -1;
        }
        public struct WordCount
        {
            public string word;
            public int number;
            public WordCount(string word, int number)
            {
                this.word = word;
                this.number = number;
            }
        }
    }
}
