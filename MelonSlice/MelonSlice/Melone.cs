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
        [TestMethod]
        public void Testpt5Kg()
        {
            Assert.AreEqual("NU", meloneSpliter(5));
        }
        [TestMethod]
        public void Testpt14Kg()
        {
            Assert.AreEqual("DA", meloneSpliter(14));
        }
        string meloneSpliter(int weightKg)
        {
            if (weightKg < 4 || weightKg % 2 != 0)            
                return "NU";            
            else            
                return "DA";           
        }
    }
}
