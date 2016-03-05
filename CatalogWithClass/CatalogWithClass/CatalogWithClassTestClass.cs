using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWithClass
{
    [TestClass]
    public class CatalogWithClassTestClass
    {
        [TestMethod]
        public void SouldReturnStringArrayWithStudentsSortedByGenMean()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu", cucuGrade);
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student bubu = new Student("Bubu", bubuGrade);
            Student[] students = {cucu,bubu };
            CatalogWithClass allClass = new CatalogWithClass(students);
            string[] expected = { "Bubu", "Cucu" };
            CollectionAssert.AreEqual(expected, allClass.SortStudentsByGenMean());
        }
        //[TestMethod]
        //public void SouldCreateAStructWithNamesAndGeneralMean()
        //{
        //    Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
        //                          new Grades("Sport", new int[] { 6, 8 })};
        //    Student cucu = new Student("Cucu", cucuGrade);
        //    Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
        //                          new Grades("Sport", new int[] { 10, 10 })};
        //    Student bubu = new Student("Bubu", bubuGrade);
        //    Student[] students = { cucu, bubu };
        //    CatalogWithClass allClass = new CatalogWithClass(students);
        //    string[] expected = { "Bubu", "Cucu" };
        //    CollectionAssert.AreEqual(expected, allClass.SortStudentsByGenMean());
        //}
    }
}
