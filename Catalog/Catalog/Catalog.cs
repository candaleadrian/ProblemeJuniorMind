using System;
using System.Collections;
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
        [TestMethod]
        public void ShouldSortTwoStudentByGeneralMean()
        {
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student { name = "Cucu", mattersAndNotes = cucuMatters };
            Maters mathBubu = new Maters("Mathematics", new int[] { 9, 8 });
            Maters sportBubu = new Maters("Sport", new int[] { 10, 9 });
            Maters[] bubuMatters = { mathBubu, sportBubu };
            Student bubu = new Student { name = "Bubu", mattersAndNotes = bubuMatters };
            Student[] allClass = { cucu, bubu };
            GeneralMean[] expected = { new GeneralMean("Bubu", 9m), new GeneralMean("Cucu", 7.5m) };
            CollectionAssert.AreEqual(expected, SortStudentsByGeneralMean(allClass));
        }
        [TestMethod]
        public void ShouldReturnStudentWithASpecificGeneralMean()
        {
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student { name = "Cucu", mattersAndNotes = cucuMatters };
            Maters mathBubu = new Maters("Mathematics", new int[] { 9, 8 });
            Maters sportBubu = new Maters("Sport", new int[] { 10, 9 });
            Maters[] bubuMatters = { mathBubu, sportBubu };
            Student bubu = new Student { name = "Bubu", mattersAndNotes = bubuMatters };
            Student[] allClass = { cucu, bubu };
            string[] expected = {"Bubu"};
            CollectionAssert.AreEqual(expected, SearchStudentsByGeneralMean(allClass,9m));
        }
        [TestMethod]
        public void ShouldReturnTwoStudentWithASpecificGeneralMean()
        {
            Maters mathZuzu = new Maters("Mathematics", new int[] { 8, 8 });
            Maters sportZuzu = new Maters("Sport", new int[] { 10, 10 });
            Maters[] zuzuMatters = { mathZuzu, sportZuzu };
            Student zuzu = new Student { name = "Zuzu", mattersAndNotes = zuzuMatters };
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student { name = "Cucu", mattersAndNotes = cucuMatters };
            Maters mathBubu = new Maters("Mathematics", new int[] { 9, 8 });
            Maters sportBubu = new Maters("Sport", new int[] { 10, 9 });
            Maters[] bubuMatters = { mathBubu, sportBubu };
            Student bubu = new Student { name = "Bubu", mattersAndNotes = bubuMatters };
            Student[] allClass = { cucu, bubu, zuzu };
            string[] expected = { "Bubu","Zuzu" };
            CollectionAssert.AreEqual(expected, SearchStudentsByGeneralMean(allClass, 9m));
        }
        [TestMethod]
        public void ShouldReturnStudentsWithTenNotes()
        {
            Maters mathZuzu = new Maters("Mathematics", new int[] { 8, 8 });
            Maters sportZuzu = new Maters("Sport", new int[] { 10, 10 });
            Maters[] zuzuMatters = { mathZuzu, sportZuzu };
            Student zuzu = new Student { name = "Zuzu", mattersAndNotes = zuzuMatters };
            Maters mathCucu = new Maters("Mathematics", new int[] { 6, 7 });
            Maters sportCucu = new Maters("Sport", new int[] { 8, 9 });
            Maters[] cucuMatters = { mathCucu, sportCucu };
            Student cucu = new Student { name = "Cucu", mattersAndNotes = cucuMatters };
            Maters mathBubu = new Maters("Mathematics", new int[] { 9, 8 });
            Maters sportBubu = new Maters("Sport", new int[] { 10, 9 });
            Maters[] bubuMatters = { mathBubu, sportBubu };
            Student bubu = new Student { name = "Bubu", mattersAndNotes = bubuMatters };
            Student[] allClass = { cucu, bubu, zuzu };
            StudWithTenNotes[] expected = { new StudWithTenNotes("Bubu",1), new StudWithTenNotes("Zuzu", 2) };
            CollectionAssert.AreEqual(expected, SudentsWithTenNotes(allClass));
        }

        private StudWithTenNotes[] SudentsWithTenNotes(Student[] allClass)
        {
            StudWithTenNotes[] studentWithTenNotes = { };
            for (int i = 0; i < allClass.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < allClass[i].mattersAndNotes.Length; j++)
                {
                    for (int x = 0; x < allClass[i].mattersAndNotes[j].notes.Length; x++)
                    {
                        if (allClass[i].mattersAndNotes[j].notes[x] == 10)
                        {
                            counter++;
                        }
                    }
                }
                    if (counter!=0)
                    {
                        Array.Resize(ref studentWithTenNotes, studentWithTenNotes.Length + 1);
                        studentWithTenNotes[studentWithTenNotes.Length - 1] = new StudWithTenNotes(allClass[i].name, counter);
                    }
            };
            return studentWithTenNotes;
        }
        public struct StudWithTenNotes
        {
            public string name;
            public int tenNotes;
            public StudWithTenNotes(string name, int tenNotes)
            {
                this.name = name;
                this.tenNotes = tenNotes;
            }
        }

        private string[] SearchStudentsByGeneralMean(Student[] allClass,decimal mean)
        {
            string[] studentsWithSpecificMean = { };
            GeneralMean[] studAndGeneralMean= SortStudentsByGeneralMean(allClass);
            for (int i = 0; i < studAndGeneralMean.Length; i++)
            {
                if (studAndGeneralMean[i].generalMean == mean)
                {
                    Array.Resize(ref studentsWithSpecificMean, studentsWithSpecificMean.Length + 1);
                    studentsWithSpecificMean[studentsWithSpecificMean.Length-1] = studAndGeneralMean[i].name;
                }
            }
            return studentsWithSpecificMean;
        }

        public GeneralMean[] SortStudentsByGeneralMean(Student[] allClass)
        {
            GeneralMean[] studAndGeneralMean = CreateStudAndGeneralMeanArray(allClass);
            return SortStudAndGeneralMean(ref studAndGeneralMean);
        }

        private GeneralMean[] SortStudAndGeneralMean(ref GeneralMean[] studAndGeneralMean)
        {
            for (int i = 0; i < studAndGeneralMean.Length-1; i++)
            {
                for (int j = i+1; j < studAndGeneralMean.Length; j++)
                {
                    if (studAndGeneralMean[i].generalMean< studAndGeneralMean[j].generalMean)
                    {
                        Swap(ref studAndGeneralMean[i],ref studAndGeneralMean[j]);
                    }
                }
            };
            return studAndGeneralMean;
        }
        private void Swap(ref GeneralMean generalMean1,ref  GeneralMean generalMean2)
        {
            GeneralMean temp = generalMean1;
            generalMean1 = generalMean2;
            generalMean2 = temp;
        }
        private GeneralMean[] CreateStudAndGeneralMeanArray(Student[] allClass)
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
