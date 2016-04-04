using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace LinkedListd
{
    public class LinkedListd<T>
    {
        private class Node
        {
            public T value;
            public Node previous;
            public Node next;
        }
        private Node guard = new Node();
        private int counter;
        public void LinkedList()
        {
            guard.next = guard;
            guard.previous = guard;

        }
        public int Count
        {
            get
            {
                return counter;
            }
        }
             
        
    }
    
}
