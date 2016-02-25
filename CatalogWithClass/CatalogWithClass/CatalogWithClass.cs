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
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student ( "Cucu", cucuMatters);
            Maters mathBubu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportBubu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] bubuMatters = { mathBubu, sportBubu };
            Student bubu = new Student ( "Bubu",bubuMatters );
            Student[] allClass = { cucu, bubu };
            CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu" }, SortStudentsAlpha(allClass));
        }
        public string[] SortStudentsAlpha(Student[] allClass)
        {
            string[] studentsNames = GetStudentNameArray(allClass);
            Array.Sort(studentsNames);
            return studentsNames;
        }
        private static string[] GetStudentNameArray(Student[] allClass)
        {
            string[] studentsNames = new string[allClass.Length];
            for (int i = 0; i < allClass.Length; i++)
            {
                studentsNames[i] = allClass[i].name;
            }
            return studentsNames;
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
            public string name;
            private Maters[] subjectAndNotes;
            public Student(string name, Maters[] subjectAndNotes)
            {
                this.name = name;
                this.subjectAndNotes = subjectAndNotes;
            }
        }
    }
}
