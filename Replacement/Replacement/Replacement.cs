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
            Assert.AreEqual("ccb",ReplaceACharWithAString("ab",'a',"cc"));
        }
        [TestMethod]
        public void ShouldReplaceACharWithAnotherStringForFiveCharString()
        {
            Assert.AreEqual("ccbccccc", ReplaceACharWithAString("abaac", 'a', "cc"));
        }
        [TestMethod]
        public void ShouldReplaceCharAWithAStringBrr()
        {
            Assert.AreEqual("BrrbBrrBrrc", ReplaceACharWithAString("abaac", 'a', "Brr"));
        }
        public string ReplaceACharWithAString(string checkedString, char toBeReplaced, string desiredString)
        {
            if (checkedString == string.Empty)
                return "";
            string result = (checkedString[0] == toBeReplaced) ? desiredString : checkedString[0].ToString();
            return result + ReplaceACharWithAString(checkedString.Substring(1), toBeReplaced,desiredString);
        }

    }
}
