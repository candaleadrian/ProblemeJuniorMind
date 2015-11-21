﻿using System;
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
        string meloneSpliter(int weightKg)
        {
            if (weightKg < 4)
            {
                return "NU";
            }
            return "DA";
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
