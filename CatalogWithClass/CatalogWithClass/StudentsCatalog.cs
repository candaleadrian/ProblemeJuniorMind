using System;
using System.Collections;

namespace Catalog
{
    public class StudentsCatalog
    {
        private Student[] allClass;
        public StudentsCatalog(Student[] allClass)
        {
            this.allClass = allClass;
        }
        public void AddStudentToTheClass(Student student)
        {
            Array.Resize(ref allClass, allClass.Length + 1);
            allClass[allClass.Length] = student;
        }
        public Student[] FindStudentsWithTheLowestGeneralMean()
        {
            Student[] result = { };
            decimal lowestGeneralMean = SearchTheLowestGeneralMean();
            foreach (var stud in allClass)
            {
                if (lowestGeneralMean == stud.CalculateGeneralMean())
                    AddStudToResult(ref result, stud);
            }
            return result;
        }
        private decimal SearchTheLowestGeneralMean()
        {
            decimal min = 11;
            foreach (var stud in allClass)
            {
                decimal temp = stud.CalculateGeneralMean();
                if (temp < min)
                    min = temp;
            }
            return min;
        }
        public Student[] FindStudentsWithTheMostTenGrades()
        {
            Student[] result = { };
            int maxNumbOfTenGrades = SearchTheBiggestNumberOfTenGrades();
            foreach (var stud in allClass)
            {
                if (maxNumbOfTenGrades == stud.CountAllTenGrades())
                    AddStudToResult(ref result, stud);
            }
            return result;
        }

        private int SearchTheBiggestNumberOfTenGrades()
        {
            int max=0;
            foreach (var stud in allClass)
            {
                int temp = stud.CountAllTenGrades();
                if (temp > max)
                    max = temp;
            }
            return max;
        }

        public Student[] FindStudentsWithSpecificGeneralMean(decimal valueToFind)
        {
            Student[] result = { };
            foreach (var stud in allClass)
            {
                if (stud.CalculateGeneralMean() == valueToFind)
                {
                    AddStudToResult(ref result, stud);
                }
            };
            return result;
        }

        private void AddStudToResult(ref Student[] result, Student stud)
        {
            Array.Resize(ref result, result.Length+1);
            result[result.Length-1] = stud;
        }

        public Student[] SortStudentsAlpha()
        {
            for (int i = 0; i < allClass.Length; i++)
            {
                for (int j = i+1; j < allClass.Length; j++)
                {
                    int c = string.Compare(allClass[i].GetStudentName(), allClass[j].GetStudentName());
                    if (c > 0)
                        Swap(ref allClass[i], ref allClass[j]);
                }
            }
            return allClass;
        }

        public Student[] SortStudentsByGenMean()
        {
            SortStruct(ref allClass);
            return allClass;
        }

        private void SortStruct(ref Student[] allStud)
        {
            for (int i = 0; i < allStud.Length - 1; i++)
            {
                for (int j = i + 1; j < allStud.Length; j++)
                {
                    if (allStud[i].CalculateGeneralMean() < allStud[j].CalculateGeneralMean())
                    {
                        Swap(ref allStud[i], ref allStud[j]);
                    }
                }
            };
        }

        private void Swap(ref Student nameAndGenMean1, ref Student nameAndGenMean2)
        {
            Student temp = nameAndGenMean1;
            nameAndGenMean1 = nameAndGenMean2;
            nameAndGenMean2 = temp;
        }
    }
}
