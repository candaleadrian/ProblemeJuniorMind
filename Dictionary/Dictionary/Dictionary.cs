using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryProgram
{
    public class DictionaryClass<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private int counter;
        private int?[] hashList;
        private DictData[] dictList;
        public DictionaryClass()
        {
            counter = 0;
            hashList = new int?[10];
            dictList = new DictData[10];
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ContainsKey(TKey key)
        {
            if (hashList[CreateHash(key)].HasValue)
            {
                var tmp = hashList[CreateHash(key)];
                do
                {
                    if (dictList[tmp.Value].key.Equals(key))
                        return true;                    
                    tmp = dictList[tmp.Value].previous;
                } while (tmp != null);
            }
            return false;
        }
        public int CreateHash(TKey key)
        {
            return Math.Abs(key.GetHashCode() % dictList.Length);
        }
        public void Add(TKey key, TValue value)
        {
            int h = CreateHash(key);
            int? previous = hashList[h];
            if (!hashList[h].HasValue)
                hashList[h] = counter;
            dictList[counter] = new DictData(key,value,previous);
            counter++;
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
