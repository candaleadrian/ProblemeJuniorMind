using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Replacement
{
    [TestClass]
    public class Replacement
    {
        [TestMethod]
        public void ShouldReplaceACharWithAnotherString()
        {
            Assert.AreEqual("ccb",ReplaceACharWithAString("ab","a","cc"));
        }
        public string ReplaceACharWithAString(string checkedString,string toBeReplaced, string desiredString)
        {
            return checkedString.Replace("a",desiredString);
        }

    }
}
