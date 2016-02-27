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
        public string[] ChoseAction(Student[] allClass,string action)
        {
            switch (action)
            {
                case "SortAlpha":
                    return SortStudentsAlpha(allClass);
                default:
                    break;
            }
            return new string[] { };
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
        public class SubjectAndGrades
        {
            private string matterName;
            private int[] notes;
            public SubjectAndGrades(string materName, int[] notes)
            {
                this.matterName = materName;
                this.notes = notes;
            }
        }
        public class Student
        {
            public string name;
            private SubjectAndGrades[] subjectAndNotes;
            public Student(string name, SubjectAndGrades[] subjectAndNotes)
            {
                this.name = name;
                this.subjectAndNotes = subjectAndNotes;
            }
        }
    }
}
