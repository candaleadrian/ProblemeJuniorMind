﻿using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryProgram
{
    public class DictionaryClass<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private int counter = -1;        
        private int[] hashList = { -1,-1, -1, -1, -1, -1, -1, -1, -1, -1};
        public DictData[] dictList = new DictData[10];
        public struct DictData
        {
            public TKey key;
            private TValue value;
            private int previous;
            public DictData(TKey key, TValue value,int previous)
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ContainsKey(TKey key)
        {
            bool result = false;
            int tmp = hashList[CreateHash(key)];
            if (tmp != -1)
            {
                if (dictList[tmp].key.Equals(key))
                {
                    result = true;
                }
            }
            return result;
        }
        public int CreateHash(TKey key)
        {
            return Math.Abs(key.GetHashCode() % dictList.Length);
        }
        public void Add(TKey key, TValue value)
        {
            int previous = -1;
            int h = CreateHash(key);
            counter++;
            if (hashList[h] == -1)
            {
                hashList[h]= counter;
            }
            else
            {
                previous = hashList[h];
            }
            dictList[counter] = new DictData(key,value,previous);
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
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
