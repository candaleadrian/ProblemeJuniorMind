using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalogWithClass
{
    [TestClass]
    public class GradesTestClass
    {
        [TestMethod]
        public void SouldReturnAverageForOneSubjectWithTwoGrades()
        {
            Grades mathGrades = new Grades("Math", new int[] { 10, 8 });
            Assert.AreEqual(9m, mathGrades.CalculateAvrerage());
        }
        [TestMethod]
        public void SouldReturnAverageForOneSubjectWithThreeGrades()
        {
            Grades mathGrades = new Grades("Math", new int[] { 10, 8,6 });
            Assert.AreEqual(8m, mathGrades.CalculateAvrerage());
        }
    }
}
