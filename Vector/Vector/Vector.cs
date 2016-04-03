using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Vector 
{
    public class VectorClass<T> : IList<T>,IEnumerable<T>,IEnumerator
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

        public object Current
        {
            get
            {
                return current;
            }
        }

        public T current
        {
            get
            {
                try
                {
                    return myList[counter];
                }
                catch (Exception)
                {

                    throw;
                }
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
            int j = arrayIndex;
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(myList[j], i);
                j++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
        for (int i = 0; i < myList.Length; i++)
        {
            yield return myList[i];
        }
        }

        public int IndexOf(T value)
        {
            int itemIndex = -1 ;
            for (int i = 0; i < Count; i++)
            {
                if (myList[i].Equals(value))
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        public void Insert(int index, T item)
        {
            if ((counter+1 <= myList.Length) && (index<Count) && (index>=0))
            {
                counter++;
                for (int i = Count-1; i > index; i--)
                {
                    myList[i] = myList[i - 1];
                }
                myList[index] = item;
            };
        }

        public bool Remove(T item)
        {
            bool result = false;
            if (Contains(item))
            {
            RemoveAt(IndexOf(item));
            result = true;
            }
            return result;
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    myList[i] = myList[i + 1];
                }
                counter--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool MoveNext()
        {
            counter++;
            return (counter < myList.Length);
        }

        public void Reset()
        {
            counter = 0;
        }
    }
}
