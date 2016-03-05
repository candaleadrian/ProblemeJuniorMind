using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalogWithClass
{
    [TestClass]
    public class CatalogWithClass
    {
        [TestMethod]
        public void ShouldSortTwoStudentAlpha()
        {
         //   Student cucu = new Student("Cucu");
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
         //   Student bubu = new Student("Bubu");
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 5, 7 })};
         //   Student[] allClass = { cucu, bubu };
         //   CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu" },allClass. SortStudentsByNameAlpha());
        }
        

    }

}
