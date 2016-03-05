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
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student bubu = new Student("Bubu");
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 5, 7 })};
            Student[] allClass = { cucu, bubu };
//            CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu" },allClass. SortStudentsByNameAlpha());
        }
        

        public class Student
        {
            private string name;
            private Grades[] grades;
            public Student(string name)
            {
                this.name = name;
            }
            public string[] SortStudentsByNameAlpha()
            {
                return new string[] { };
            }
            public decimal CalculateGeneralMean()
            {
                decimal sum = 0;
                foreach (var subj in grades)
                {
          //          sum += CalculateAvrerage(subj.);
                }
                return 0;
            }

        }
        [TestMethod]
        public void SouldReturnAverageForOneSubject()
        {
            Grades mathGrades = new Grades("Math", new int[] { 10, 8 });
            Assert.AreEqual(9m,mathGrades.CalculateAvrerage());
        }

        public class Grades
        {
            private string subject;
            private int[] grades;
            public Grades(string subject, int[] grade)
            {
                this.subject = subject;
                this.grades = grade;
            }
            public decimal CalculateAvrerage()
            {
                decimal sum = 0;
                foreach (var grade in grades)
                {
                    sum += grade;
                }
                return sum / grades.Length;
            }
        }
    }

}
