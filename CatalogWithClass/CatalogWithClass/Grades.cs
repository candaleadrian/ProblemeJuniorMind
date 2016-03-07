﻿namespace CatalogWithClass
{
    public class Grades
    {
        private string subject;
        private int[] grades;
        public Grades(string subject, int[] grade)
        {
            this.subject = subject;
            this.grades = grade;
        }
        public decimal CalculateAvrerage()
        {
            decimal sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }
    }
}
