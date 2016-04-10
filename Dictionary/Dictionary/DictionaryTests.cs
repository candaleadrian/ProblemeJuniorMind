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
            Dictionary<int> dictList = new Dictionary<int>();
            int expected = 0;
            Assert.Equal(expected, dictList.Count);
        }
    }
}
