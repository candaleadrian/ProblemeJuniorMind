﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
