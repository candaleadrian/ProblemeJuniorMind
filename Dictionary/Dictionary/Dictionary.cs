﻿using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryProgram
{
    public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private int counter;
        private int?[] bucket;
        private DictData[] elements;
        private int? freeIndex;
        public Dictionary()
        {
            counter = 0;
            bucket = new int?[10];
            elements = new DictData[10];
        }

        private struct DictData
        {
            public TKey key;
            public TValue value;
            public int? previous;
            public DictData(TKey key, TValue value,int? previous)
            {
                this.key = key;
                this.value = value;
                this.previous = previous;
            }
        }
        public ICollection<TKey> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }

        public TValue this[TKey key]
        {
            get
            {
               return elements[ReturnElementsIndexForTheKey(key)].value;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ContainsKey(TKey key)
        {
            if (ReturnElementsIndexForTheKey(key)>=0)
                return true;
            return false;
        }

        private int ReturnElementsIndexForTheKey(TKey key)
        {
            var index = CreateHash(key);
            if (bucket[index].HasValue)
            {
                var tmp = bucket[index];
                do
                {
                    if (elements[tmp.Value].key.Equals(key))
                          return tmp.Value;                    
                        tmp = elements[tmp.Value].previous;
                } while (tmp != null);
            }
            return -1;
        }

        public int CreateHash(TKey key)
        {
            return Math.Abs(key.GetHashCode() % bucket.Length);
        }
        public void Add(TKey key, TValue value)
        {
            int hash = CreateHash(key);
            int? previous = bucket[hash];
            int index = ReturnElementsFirstEmptyIndex();
            if (index >= 0)
            {
                elements[index] = new DictData(key, value, previous);
                bucket[hash] = index;
                counter++;
            }
        }

        private int ReturnElementsFirstEmptyIndex()
        {
            if (freeIndex!=null)
            {
                int? tmp = freeIndex;
                freeIndex = elements[freeIndex.Value].previous;
                return tmp.Value;
            }
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].key == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(TKey key)
        {
            int index = ReturnElementsIndexForTheKey(key);
            if (index<0)
                return false;
            int hash = CreateHash(key);
            DictData tmp = elements[bucket[hash].Value];
            do
            {
                if (tmp.key.Equals(key))
                {
                    if (tmp.previous == null && bucket[hash] == index )
                    {
                        bucket[hash] = null;
                        return true;
                    }
                    if (bucket[hash]==index)
                        bucket[hash] = tmp.previous;
                    elements[index].previous = freeIndex;
                    freeIndex = index;
                    return true;
                }
                if (tmp.previous==index)
                {
                    CorrectElementPreviousIFPreviousIsRemoved(tmp);
                }
                tmp = elements[tmp.previous.Value];
            } while (freeIndex != index);
            return true;
        }

        private void CorrectElementPreviousIFPreviousIsRemoved(DictData tmp)
        {
            elements[ReturnElementsIndexForTheKey(tmp.key)].previous = elements[tmp.previous.Value].previous;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            counter = -1;
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
