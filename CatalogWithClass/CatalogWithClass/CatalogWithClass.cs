using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalogWithClass
{
    [TestClass]
    public class CatalogWithClass
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
    public class Maters
    {
        private string matterName;
        private int[] notes;
        public Maters(string materName, int[] notes)
        {
            this.matterName = materName;
            this.notes = notes;
        }
    }
    public class Student
    {
        private string name;
        public Maters[] mattersAndNotes;
    }

}
