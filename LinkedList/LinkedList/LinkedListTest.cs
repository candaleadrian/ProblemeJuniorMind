﻿using System;
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
    }
}
