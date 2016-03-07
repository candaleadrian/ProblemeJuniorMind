using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalogWithClass
{
    [TestClass]
    public class StudentTestClass
    {
        [TestMethod]
        public void ShouldCalculateGeneralMeanForOneStudent()
        {
            Grades[] cucuGrade = { new Grades("Math", new int[] { 10, 8 }),
                                  new Grades("Sport", new int[] { 6, 8 })};
            Student cucu = new Student("Cucu",cucuGrade);
            Assert.AreEqual(8, cucu.CalculateGeneralMean());
        }
    }
}
