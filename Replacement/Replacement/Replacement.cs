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
        [TestMethod]
        public void ShouldReplaceACharWithAnotherStringForFiveCharString()
        {
            Assert.AreEqual("ccbccccc", ReplaceACharWithAString("abaac", "a", "cc"));
        }
        public string ReplaceACharWithAString(string checkedString,string toBeReplaced, string desiredString)
        {
            return checkedString.Replace(toBeReplaced,desiredString);
        }

    }
}
