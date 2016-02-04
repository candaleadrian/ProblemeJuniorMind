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
        [TestMethod]
        public void ShouldReturnSortedWordsForThreeWordsText()
        {
            WordCount[] expected = new WordCount[2];
            expected[0] = new WordCount("abc", 2);
            expected[1] = new WordCount("bbc", 1);
            expected[2] = new WordCount(null, 0);
            CollectionAssert.AreEqual(expected, SortText("bbc abc abc"));
        }
        [TestMethod]
        public void ShouldReturnSortedWordsForThreeObjectsStruct()
        {
            WordCount[] expected = new WordCount[2];
            expected[0] = new WordCount("abc", 2);
            expected[1] = new WordCount("bbc", 1);
            WordCount[] toCheck = new WordCount[2];
            toCheck[0] = new WordCount("bbc", 1);
            toCheck[1] = new WordCount("abc", 2);
            CollectionAssert.AreEqual(expected, SortStruct(toCheck));
        }
        public WordCount[] SortText(string textToSort)
        {
            string[] textArray = textToSort.Split(' ');
            var wordCount = new WordCount[textArray.Length];
            int length = 0;
            for (int i = 0; i < textArray.Length; i++)
            {
                int pos = ReturnPositionOrNegative(wordCount,textArray[i]);
                if (pos < 0)
                {
                    wordCount[length].word = textArray[i];
                    wordCount[length].number = 1;
                    length++;
                }
                else
                    wordCount[pos].number++;       
            }
            return SortStruct(wordCount);
        }

        private WordCount[] SortStruct(WordCount[] wordCount)
        {
            for (int i = 0; i < wordCount.Length; i++)
            {
                for (int j = i; j < wordCount.Length-1; j++)
                {
                    OrderStructByBiggestNumber(wordCount, j);
                }
            }
            return wordCount;
        }

        private static void OrderStructByBiggestNumber(WordCount[] wordCount, int j)
        {
            if (wordCount[j].number < wordCount[j + 1].number)
            {
                var temp = wordCount[j + 1];
                wordCount[j + 1] = wordCount[j];
                wordCount[j] = temp;
            }
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
