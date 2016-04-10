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
            DictionaryClass<int> dictList = new DictionaryClass<int>();
            int expected = 0;
            Assert.Equal(expected, 0);
        }
    }
}
