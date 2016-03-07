namespace CatalogWithClass
{
    public class Student
    {
        private string name;
        private Grades[] grades;
        public Student(string name, Grades[] grades)
        {
            this.name = name;
            this.grades = grades;
        }
        public string GetStudentName()
        {
            return name;
        }
        public decimal CalculateGeneralMean()
        {
            decimal sum = 0;
            foreach (var subj in grades)
            {
                sum += subj.CalculateAvrerage();
            }
            return sum/grades.Length;
        }

    }
}
