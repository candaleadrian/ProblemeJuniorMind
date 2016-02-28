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
            SubjectAndGrades[] cucuGrades = { new SubjectAndGrades("Mathematics", new int[] { 6, 7 }),
                                               new SubjectAndGrades("Sport", new int[] { 8, 9 }) };
            SubjectAndGrades[] bubuGrades = { new SubjectAndGrades("Mathematics", new int[] { 6, 7 }),
                                               new SubjectAndGrades("Sport", new int[] { 8, 9 }) };
            Student[] allClass = { new Student("Cucu", cucuGrades),
                                   new Student("Bubu", bubuGrades) };
            CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu" }, SortStudentsAlpha(allClass));
        }
        [TestMethod]
        public void ShouldAddNewStudentAndSubsectWithGradesAndSortAlpha()
        {
            SubjectAndGrades[] cucuGrades = { new SubjectAndGrades("Mathematics", new int[] { 6, 7 }),
                                               new SubjectAndGrades("Sport", new int[] { 8, 9 }) };
            SubjectAndGrades[] bubuGrades = { new SubjectAndGrades("Mathematics", new int[] { 6, 7 }),
                                               new SubjectAndGrades("Sport", new int[] { 8, 9 }) };
            SubjectAndGrades[] luluGrades = { new SubjectAndGrades("Mathematics", new int[] { 4, 10 }),
                                               new SubjectAndGrades("Sport", new int[] { 10, 2 }) };
            Student[] allClass = { new Student("Cucu", cucuGrades),
                                   new Student("Bubu", bubuGrades) };
            AddNewStudToClass(ref allClass, "Lulu", luluGrades);
            CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu","Lulu" }, ChoseAction(allClass, "SortAlpha"));
        }
        [TestMethod]
        public void ShouldSortStudentByGeneralMean()
        {
            SubjectAndGrades[] cucuGrades = { new SubjectAndGrades("Mathematics", new int[] { 6, 7 }),
                                               new SubjectAndGrades("Sport", new int[] { 8, 9 }) };
            SubjectAndGrades[] bubuGrades = { new SubjectAndGrades("Mathematics", new int[] { 10, 10 }),
                                               new SubjectAndGrades("Sport", new int[] { 9, 9 }) };
            SubjectAndGrades[] luluGrades = { new SubjectAndGrades("Mathematics", new int[] { 4, 10 }),
                                               new SubjectAndGrades("Sport", new int[] { 10, 2 }) };
            Student[] allClass = { new Student("Cucu", cucuGrades),
                                   new Student("Bubu", bubuGrades) };
            AddNewStudToClass(ref allClass, "Lulu", luluGrades);
            CollectionAssert.AreEqual(new string[] { "Bubu", "Cucu", "Lulu" }, ChoseAction(allClass, "SortByGenMean"));
        }
        [TestMethod]
        public void ShouldSortFourStudentByGeneralMean()
        {
            SubjectAndGrades[] cucuGrades = { new SubjectAndGrades("Mathematics", new int[] { 6, 7 }),
                                               new SubjectAndGrades("Sport", new int[] { 8, 9 }) };
            SubjectAndGrades[] bubuGrades = { new SubjectAndGrades("Mathematics", new int[] { 10, 10 }),
                                               new SubjectAndGrades("Sport", new int[] { 9, 9 }) };
            SubjectAndGrades[] luluGrades = { new SubjectAndGrades("Mathematics", new int[] { 4, 10 }),
                                               new SubjectAndGrades("Sport", new int[] { 10, 2 }) };
            SubjectAndGrades[] duduGrades = { new SubjectAndGrades("Mathematics", new int[] { 10, 10 }),
                                               new SubjectAndGrades("Sport", new int[] { 10, 10 }) };
            Student[] allClass = { new Student("Cucu", cucuGrades),
                                   new Student("Bubu", bubuGrades) };
            AddNewStudToClass(ref allClass, "Lulu", luluGrades);
            AddNewStudToClass(ref allClass, "Dudu", duduGrades);
            CollectionAssert.AreEqual(new string[] { "Dudu","Bubu", "Cucu", "Lulu" }, ChoseAction(allClass, "SortByGenMean"));
        }
        public string[] ChoseAction(Student[] allClass,string action)
        {
            switch (action)
            {
                case "SortAlpha":
                    return SortStudentsAlpha(allClass);
                case "SortByGenMean":
                    return SortStudentsByGenMean(allClass);
                default:
                    break;
            }
            return new string[] { };
        }

        private string[] SortStudentsByGenMean(Student[] allClass)
        {
            NameAndGenMean[] nameAndGenMean = new NameAndGenMean[allClass.Length];
            for (int i = 0; i < allClass.Length; i++)
            {
                decimal genMean = CalculateGenMeanForEachStud(allClass[i].subjectAndNotes);
                nameAndGenMean[i] = new NameAndGenMean(allClass[i].name, genMean);
            }
            SortStudByGenMean(ref nameAndGenMean);
            return ReturnSortedStudByGenMean(nameAndGenMean);
            
        }

        private string[] ReturnSortedStudByGenMean(NameAndGenMean[] nameAndGenMean)
        {
            string[] students = new string[nameAndGenMean.Length];
            for (int i = 0; i < nameAndGenMean.Length; i++)
            {
                students[i] = nameAndGenMean[i].name;
            }
            return students;
        }

        private void SortStudByGenMean(ref NameAndGenMean[] nameAndGenMean)
        {
            for (int i = 0; i < nameAndGenMean.Length - 1; i++)
            {
                for (int j = i + 1; j < nameAndGenMean.Length; j++)
                {
                    if (nameAndGenMean[i].genMean < nameAndGenMean[j].genMean)
                    {
                        Swap(ref nameAndGenMean[i], ref nameAndGenMean[j]);
                    }
                }
            };
        }
        private void Swap(ref NameAndGenMean generalMean1, ref NameAndGenMean generalMean2)
        {
            NameAndGenMean temp = generalMean1;
            generalMean1 = generalMean2;
            generalMean2 = temp;
        }

        private decimal CalculateGenMeanForEachStud(SubjectAndGrades[] subjectAndNotes)
        {
            decimal sum = 0;
            foreach (var subject in subjectAndNotes)
            {
                sum += CalcualteMeanForEachSubject(subject);
            }
            return sum / subjectAndNotes.Length;
        }

        private static decimal CalcualteMeanForEachSubject(SubjectAndGrades subject)
        {
            int sumSubjGrades = 0;
            foreach (var grades in subject.notes)
            {
                sumSubjGrades += grades;
            }
            return sumSubjGrades / subject.notes.Length;
        }

        public string[] SortStudentsAlpha(Student[] allClass)
        {
            string[] studentsNames = GetStudentNameArray(allClass);
            Array.Sort(studentsNames);
            return studentsNames;
        }
        public string[] GetStudentNameArray(Student[] allClass)
        {
            string[] studentsNames = new string[allClass.Length];
            for (int i = 0; i < allClass.Length; i++)
            {
                studentsNames[i] = allClass[i].name;
            }
            return studentsNames;
        }
        public void AddNewStudToClass(ref Student[] allClass,string name, SubjectAndGrades[] subjectAndNotes)
        {
            Array.Resize(ref allClass, allClass.Length + 1);
            allClass[allClass.Length - 1] = new Student(name, subjectAndNotes);
        }
        public void AddNewSubjectAndGrades(string subject, int[] grades)
        {
            SubjectAndGrades[] temp = { };
            Array.Resize(ref temp, temp.Length +1);
            temp[temp.Length - 1] = new SubjectAndGrades(subject, grades);            
        }
        public class NameAndGenMean
        {
            public string name;
            public decimal genMean;
            public NameAndGenMean(string name, decimal genMean)
            {
                this.name = name;
                this.genMean = genMean;
            }
        }
        public class SubjectAndGrades
        {
            private string matterName;
            public int[] notes;
            public SubjectAndGrades(string materName, int[] notes)
            {
                this.matterName = materName;
                this.notes = notes;
            }
        }
        public class Student
        {
            public string name;
            public SubjectAndGrades[] subjectAndNotes;
            public Student(string name, SubjectAndGrades[] subjectAndNotes)
            {
                this.name = name;
                this.subjectAndNotes = subjectAndNotes;
            }
        }
    }
}
