using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DictionaryProgram
{
    public class DictionaryTests
    {
        [Fact]
        public void ShouldReturnNullForCounter()
        {
            DictionaryClass<int, string> dictList = new DictionaryClass<int, string>();
            int result = dictList.Count;
            int expected = -1;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ShouldCheckIfAddWorks()
        {
            DictionaryClass<string, int> dictList = new DictionaryClass<string, int>();
            dictList.Add("dogs", 7);
            int result = dictList.Count;
            int expected = 0;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ShouldCheckIfContainsKeyReturnsTrue()
        {
            DictionaryClass<string, int> dictList = new DictionaryClass<string, int>();
            dictList.Add("dogs", 7);
            dictList.Add("cats", 15);
            bool result = dictList.ContainsKey("dogs");
            Assert.True(result);
        }
        [Fact]
        public void ShouldCheckIfContainsKeyReturnsFalse()
        {
            DictionaryClass<string, int> dictList = new DictionaryClass<string, int>();
            dictList.Add("dogs", 7);
            dictList.Add("cats", 15);
            bool result = dictList.ContainsKey("dog");
            Assert.False(result);
        }
        [Fact]
        public void CheckH()
        {
            DictionaryClass<string, int> dictList = new DictionaryClass<string, int>();
            dictList.Add("dogs", 7);
            int result = dictList.ReturnH("pppt");
            Assert.True(result<10);
        }
    }
}
