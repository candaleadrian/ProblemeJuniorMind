﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class Password
    {
        [TestMethod]
        public void ShouldReturnARandomPasswordContainingSixRandomLeters()
        {
            Assert.AreEqual(6,GeneratePassword(Options[0]).Length);
        }
        string GeneratePassword(PasswordOptions Option)
        {
            string password = string.Empty;
            for (int i = 0; i < Options[0].length; i++)
            {
                password += (char)random.Next(61, 123);
            }
            return password;
        }
        public Random random = new Random();
        public struct PasswordOptions
        {
            public int length;
        }
        public PasswordOptions[] Options =
        {
            new PasswordOptions {length = 6 }
        };
    }
}
