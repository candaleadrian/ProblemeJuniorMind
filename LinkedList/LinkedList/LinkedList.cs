using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;


namespace LinkedList
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T value;
            public Node previous;
            public Node next;
        }
        private Node guard = new Node();
        private int counter;
        public LinkedList()
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
        public void Add(T item)
        {
            Node node = new Node();
            node.value = item;
            node.next = guard;
            node.previous = guard.previous;
            node.previous.next = node;
            guard.previous = node;
            counter++;
        }
        public void Clear()
        {
            counter = 0;
        }
        public bool Conteins(T item)
        {
            bool result = false;
            Node tmp = guard.next;
            while (!tmp.Equals(guard))
            {
                if (tmp.value.Equals(item))
                {
                    result = true;
                    break;
                }
                tmp = tmp.next;
            }
            return result;
        }
        public void CopyTo(T[] array,int index)
        {
            int j = index;
            Node tmp = guard.next;
            while (!tmp.Equals(guard) && index < array.Length && j<array.Length)
            {
                array.SetValue(tmp.value, j);
                j++;
                tmp = tmp.next;
            }
        }
    }
    
}
