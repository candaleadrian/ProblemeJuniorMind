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
        public void ShouldoReturnNullForCounter()
        {
            DictionaryClass<int, string> dictList = new DictionaryClass<int, string> ();
            int result = dictList.Count;
            int expected = -1;
            Assert.Equal(expected, result);
        }
    }
}
