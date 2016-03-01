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
            Student cucu = new Student("Cucu");
            Grade[] cucuGrade = { new Grade("Math", new int[] { 10, 8 }),
                                  new Grade("Sport", new int[] { 6, 8 })};
            Student bubu = new Student("Bubu");
            Grade[] bubuGrade = { new Grade("Math", new int[] { 7, 9 }),
                                  new Grade("Sport", new int[] { 5, 7 })};
            Student[] allClass = { cucu, bubu };
            CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu" }, SortStudentsByNameAlpha());
        }

        public class Student
        {
            private string name;
            private Grade[] grades;
            public Student(string name)
            {
                this.name = name;
            }
            public string[] SortStudentsByNameAlpha()
            {
                return new string[] { };
            }

        }
        public class Grade
        {
            private string subject;
            private int[] grade;
            public Grade(string subject, int[] grade)
            {
                this.subject = subject;
                this.grade = grade;
            }
        }
    }

}
