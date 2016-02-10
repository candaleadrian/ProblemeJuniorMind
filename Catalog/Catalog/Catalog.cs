using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class Catalog
    {
        [TestMethod]
        public void ShouldReturnStringArrayForOneStudent()
        {
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student { name = "Cucu", mattersAndNotes = cucuMatters };
            Student[] allClass = { cucu };
            CollectionAssert.AreEqual(new string[] { "Cucu" }, SortStudentsAlpha(allClass));
        }
        [TestMethod]
        public void ShouldSortTwoStudentAlpha()
        {
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student { name = "Cucu", mattersAndNotes = cucuMatters };
            Maters mathBubu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportBubu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] bubuMatters = { mathBubu, sportBubu };
            Student bubu = new Student { name = "Bubu", mattersAndNotes = bubuMatters };
            Student[] allClass = { cucu, bubu};
            CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu" }, SortStudentsAlpha(allClass));

        }
        public string[] SortStudentsAlpha(Student[] allClass)
        {
            string[] studentsNames = new string[allClass.Length];
            for (int i = 0; i < allClass.Length; i++)
            {
                studentsNames[i] = allClass[i].name;
            }
            return studentsNames;
        }
        public struct Student
        {
            public string name;
            public Maters[] mattersAndNotes;
        }
        public struct Maters
        {
            public string matterName;
            public int[] notes;
            public Maters(string materName, int[] notes)
            {
                this.matterName = materName;
                this.notes = notes;
            }
        }
     //   Array.Sort(words, (x, y) => x.CompareTo(y));
    }
}
