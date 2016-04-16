using System;
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
                return ValueOfKey(key);
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ContainsKey(TKey key)
        {
            if (!ValueOfKey(key).Equals(default(TValue)))
                return true;
            return false;
        }

        private TValue ValueOfKey(TKey key)
        {
            if (bucket[CreateHash(key)].HasValue)
            {
                var tmp = bucket[CreateHash(key)];
                do
                {
                    if (elements[tmp.Value].key.Equals(key))
                          return elements[tmp.Value].value;                    
                        tmp = elements[tmp.Value].previous;
                } while (tmp != null);
            }
            return default(TValue);
        }

        public int CreateHash(TKey key)
        {
            return Math.Abs(key.GetHashCode() % bucket.Length);
        }
        public void Add(TKey key, TValue value)
        {
            int hash = CreateHash(key);
            int? previous = bucket[hash];
            if (!bucket[hash].HasValue)
                bucket[hash] = counter;
            elements[counter] = new DictData(key,value,previous);
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
