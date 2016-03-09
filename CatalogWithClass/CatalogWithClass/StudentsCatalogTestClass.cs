using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class StudentsCatalogTestClass
    {
        [TestMethod]
        public void SouldReturnStudentArrayWithStudentsSortedByGenMean()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu", cucuGrade);
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student bubu = new Student("Bubu", bubuGrade);
            Student[] students = {cucu,bubu };
            StudentsCatalog allClass = new StudentsCatalog(students);
            Student[] expected = { bubu, cucu };
            CollectionAssert.AreEqual(expected, allClass.SortStudentsByGenMean());
        }
        [TestMethod]
        public void SouldreturnStudentsArraySortedByGeneralMean()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu", cucuGrade);
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student bubu = new Student("Bubu", bubuGrade);
            Grades[] tutuGrade = { new Grades("Math", new int[] { 10, 10 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student tutu = new Student("Tutu", tutuGrade);
            Student[] students = { cucu, bubu, tutu };
            StudentsCatalog allClass = new StudentsCatalog(students);
            Student[] expected = { tutu, bubu, cucu };
            CollectionAssert.AreEqual(expected, allClass.SortStudentsByGenMean());
        }
        [TestMethod]
        public void SouldReturnStudentArraySortedAlpha()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu", cucuGrade);
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student bubu = new Student("Bubu", bubuGrade);
            Grades[] tutuGrade = { new Grades("Math", new int[] { 10, 10 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student tutu = new Student("Tutu", tutuGrade);
            Student[] students = { cucu, bubu, tutu };
            StudentsCatalog allClass = new StudentsCatalog(students);
            Student[] expected = { bubu, cucu, tutu };
            CollectionAssert.AreEqual(expected, allClass.SortStudentsAlpha());
        }
        [TestMethod]
        public void SouldReturnArrayWithStudentsWithASpecificGeneralMean()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu", cucuGrade);
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student bubu = new Student("Bubu", bubuGrade);
            Grades[] tutuGrade = { new Grades("Math", new int[] { 10, 10 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student tutu = new Student("Tutu", tutuGrade);
            Student[] students = { cucu, bubu, tutu };
            StudentsCatalog allClass = new StudentsCatalog(students);
            Student[] expected = { tutu };
            CollectionAssert.AreEqual(expected, allClass.FindStudentsWithSpecificGeneralMean(10));
        }
        [TestMethod]
        public void SouldReturnStudentsWithHighestNumberOfTenGrades()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu", cucuGrade);
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student bubu = new Student("Bubu", bubuGrade);
            Grades[] tutuGrade = { new Grades("Math", new int[] { 10, 10 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student tutu = new Student("Tutu", tutuGrade);
            Student[] students = { cucu, bubu, tutu };
            StudentsCatalog allClass = new StudentsCatalog(students);
            Student[] expected = { tutu };
            CollectionAssert.AreEqual(expected, allClass.FindStudentsWithTheMostTenGrades());
        }
        [TestMethod]
        public void SouldReturnStudentsWithLowestGeneralMean()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu", cucuGrade);
            Grades[] bubuGrade = { new Grades("Math", new int[] { 7, 9 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student bubu = new Student("Bubu", bubuGrade);
            Grades[] tutuGrade = { new Grades("Math", new int[] { 10, 10 }),
                                  new Grades("Sport", new int[] { 10, 10 })};
            Student tutu = new Student("Tutu", tutuGrade);
            Student[] students = { cucu, bubu, tutu };
            StudentsCatalog allClass = new StudentsCatalog(students);
            Student[] expected = { cucu };
            CollectionAssert.AreEqual(expected, allClass.FindStudentsWithTheLowestGeneralMean());
        }
    }
}
