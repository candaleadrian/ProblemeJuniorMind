using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MelonSlice
{
    [TestClass]
    public class Melone
    {
        [TestMethod]
        public void Testpt1Kg()
        {
            Assert.AreEqual ("NU", meloneSpliter(1));
        }
        [TestMethod]
        public void Testpt4Kg()
        {
            Assert.AreEqual("DA", meloneSpliter(4));
        }
        string meloneSpliter(int weightKg)
        {
            if (weightKg < 4)
            {
                return "NU";
            }
            string answer = weightKg % 2 == 0 ? "DA" : "NU";
            return answer;
        }
    }
}
// x / 2
// 1  nu
// 2  nu
// 3  nu
// 4  da
// 5  nu
// 6  da
