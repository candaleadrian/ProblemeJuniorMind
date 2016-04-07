using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace LinkedList
{
    public class LinkedListTest
    {
        [Fact]
        public void ShouldReturnZeroForAnEmptyList()
        {
            LinkedList<int> myList = new LinkedList<int>();
            int result = myList.Count;
            Assert.Equal(0, result);
        }
        [Fact]
        public void ShouldReturnOneForOneElementList()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(0);
            int result = myList.Count;
            Assert.Equal(1, result);
        }
        [Fact]
        public void ShouldAddTwoElementsAndReturnTworElementCountList()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(0);
            myList.Add(4);
            int result = myList.Count;
            Assert.Equal(2, result);
        }
        [Fact]
        public void ShouldReturnZeroAfterClear()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(0);
            myList.Add(4);
            myList.Clear();
            int result = myList.Count;
            Assert.Equal(0, result);
        }
        [Fact]
        public void ShouldReturnTrueIfListConteinsElement()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(0);
            myList.Add(4);
            myList.Add(7);
            bool result = myList.Conteins(4);
            Assert.True(result);
        }
        [Fact]
        public void ShouldReturnAnArrayWithElementsFromList()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(0);
            myList.Add(4);
            myList.Add(7);
            int[] result = new int[3];
            myList.CopyTo(result,0);
            int[] expected = { 0, 4, 7 };
            Assert.Equal(expected,result);
        }
        [Fact]
        public void ShouldReturnAnArrayWithElementsFromListStartingFromOne()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(3);
            myList.Add(4);
            myList.Add(7);
            int[] result = new int[2];
            myList.CopyTo(result, 1);
            int[] expected = { 0, 3 };
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ShouldRemoveFirstElementWithValueFour()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(0);
            myList.Add(4);
            myList.Add(7);
            myList.Remove(4);
            int[] expected = { 0, 7 };
            int[] result = new int[2];
            myList.CopyTo(result, 0);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ShouldRemoveFirstElementWithValueFourButNotTheSecond()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(0);
            myList.Add(4);
            myList.Add(4);
            myList.Add(7);
            myList.Remove(4);
            int[] expected = { 0,4, 7 };
            int[] result = new int[3];
            myList.CopyTo(result, 0);
            Assert.Equal(expected, result);
        }
    }
}
