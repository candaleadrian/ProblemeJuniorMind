using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dictionary
{
    public class Dictionary<T>
    {
        int[] hash = new int[3];
        private class Dict
        {
            public int privious;
            public string key;
            public T value;
        }
        Dict[] dictList = new Dict[9]; 
    }
}
