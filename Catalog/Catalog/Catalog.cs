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
        [TestMethod]
        public void ShouldReturnGeneralMeanForOneStudent()
        {
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student { name = "Cucu", mattersAndNotes = cucuMatters };
            Student[] allClass = { cucu };
            GeneralMean[] expected = { new GeneralMean("Cucu", 7.5m) };
            CollectionAssert.AreEqual(expected, SortStudentsByGeneralMean(allClass));
        }
        [TestMethod]
        public void ShouldReturnMeanForOneMatterNotes()
        {
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Assert.AreEqual(6.5m, CalculateMeanForMatter(mathCucu));
        }
        public GeneralMean[] SortStudentsByGeneralMean(Student[] allClass)
        {
            GeneralMean[] studAndGeneralMean = new GeneralMean[allClass.Length];
            for (int i = 0; i < allClass.Length; i++)
            {
                studAndGeneralMean[i].name = allClass[i].name;
                studAndGeneralMean[i].generalMean = CalculateGeneralMean(allClass[i]);
            }
            return studAndGeneralMean;
        }

        private decimal CalculateGeneralMean(Student student)
        {
            decimal sum = 0;
            for (int i = 0; i < student.mattersAndNotes.Length; i++)
            {
            sum += CalculateMeanForMatter(student.mattersAndNotes[i]);
            }
            return sum/student.mattersAndNotes.Length;
        }

        private decimal CalculateMeanForMatter(Maters maters)
        {
            int sum = 0;
            for (int i = 0; i < maters.notes.Length; i++)
            {
            sum += maters.notes[i];
            }
            return (decimal)sum / maters.notes.Length;
        }

        public struct GeneralMean
        {
            public string name;
            public decimal generalMean;
            public GeneralMean(string name,decimal generalMean)
            {
                this.name = name;
                this.generalMean = generalMean;
            }
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
    }
}
