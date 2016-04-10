using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryProgram
{
    public class Dictionary<T>
    {
        int counter;
        int[] hash = new int[3];
        private class Dict
        {
            public int privious;
            public string key;
            public T value;
        }
        Dict[] dictList = new Dict[9];
        public int Count
        {
            get
            {
                return counter;
            }
        }
    }
}
