﻿using System;
using System.Collections;
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
           CollectionAssert.AreEqual(structArray, SortTextByApearence("abc"));
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
            var structArray = new WordCount[] { new WordCount("bbc", 1),
                                                new WordCount("abc", 1) };
            var result = ReturnPositionOrNegative(structArray, "abc");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void ShouldReturnSortedWordsForThreeWordsText()
        {
            var expected = new WordCount[] { new WordCount("abc", 2),
                                             new WordCount("bbc", 1)};
            CollectionAssert.AreEqual(expected, SortTextByApearence("bbc abc abc"));
        }
        [TestMethod]
        public void ShouldReturnSortedWordsForThreeObjectsStruct()
        {
            var expected = new WordCount[] { new WordCount("abc", 2), new WordCount("bbc", 1) };
            var toCheck =  new WordCount[] { new WordCount("bbc", 1), new WordCount("abc", 2) };
            CollectionAssert.AreEqual(expected, SortStruct(toCheck));
        }
        [TestMethod]
        public void ShouldReturnTheWordWithTwoApearencesInText()
        {
            Assert.AreEqual("abc", SearchForWordWithSpecificNumbersOfApearence("bbc abc abc", 2));
        }
        [TestMethod]
        public void ShouldReturnWordsWithTwoApearences()
        {
            var list = new WordCount[] { new WordCount("abc", 2),
                                             new WordCount("bbc", 1)};
            Assert.AreEqual("abc", CheckBinary(list,2));
        }
        [TestMethod]
        public void ShouldReturnTheWordWithThreeApearencesInText()
        {
            Assert.AreEqual("abc", SearchForWordWithSpecificNumbersOfApearence("bbc abc abc bbc afg mpg abc afg", 3));
        }

        private string SearchForWordWithSpecificNumbersOfApearence(string textToCheck, int numOfApearence)
        {
            WordCount[] wordAndApearence = SortTextByApearence(textToCheck);
            string result = CheckBinary(wordAndApearence, numOfApearence);
            return result;
        }

        private string CheckBinary(WordCount[] wordAndApearence, int numOfApearence)
        {
            int start = 0;
            int end = wordAndApearence.Length - 1;
            while (start<=end)
            {
                int mid = (start + end) / 2;
                if (wordAndApearence[mid].number == numOfApearence)
                    return wordAndApearence[mid].word;
                if ( wordAndApearence[mid].number < numOfApearence)
                    end = mid - 1;
                else 
                    start = mid + 1;
            }
            return "";
        }

        public WordCount[] SortTextByApearence(string textToSort)
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
            Array.Resize(ref wordCount, length);     
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
