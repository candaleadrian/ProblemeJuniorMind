using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
