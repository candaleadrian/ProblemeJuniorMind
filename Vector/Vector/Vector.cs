using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Vector
{
    public class VectorClass<T> : IList<T>
    {
        private T[] myList = new T[10];
        private int counter;
        public VectorClass()
        {
            counter = 0;
        }
        public T this[int index]
        {
            get
            {
                return myList[index];
            }

            set
            {
                myList[index]=value;
            }
        }

        public int Count
        {
            get
            {
                return counter;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T value)
        {
            if (counter < myList.Length)
            {
                myList[counter] = value;
                counter++;
            }
        }

        public void Clear()
        {
            counter = 0;
        }

        public bool Contains(T value)
        {
            bool result = false;
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i].Equals(value))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
