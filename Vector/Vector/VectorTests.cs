﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void ShouldAddANewValueToTheList()
        {
            VectorClass<int> list = new VectorClass<int>();
            list.Add(1);
        }
    }
}
