using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalogWithClass
{
    public class CatalogWithClass
    {
        private Student[] allClass;
        public CatalogWithClass(Student[] allClass)
        {
            this.allClass = allClass;
        }
        public void AddStudentToTheClass(Student student)
        {
            Array.Resize(ref allClass, allClass.Length + 1);
            allClass[allClass.Length] = student;
        }
        public string[] SortStudentsByGenMean()
        {
            NameAndGenMean[] allStud = new NameAndGenMean[allClass.Length];
            GroupNameAndGeneralMean(ref allStud);
            SortStruct(ref allStud);
            string[] result = CreateSortedNamesArray(allStud);
            return result;
        }

        private string[] CreateSortedNamesArray(NameAndGenMean[] allStud)
        {
            string[] result = new string[allStud.Length];
            for (int i = 0; i < allStud.Length; i++)
            {
                result[i] = allStud[i].name;
            }
            return result;
        }

        private void SortStruct(ref NameAndGenMean[] allStud)
        {
            for (int i = 0; i < allStud.Length - 1; i++)
            {
                for (int j = i + 1; j < allStud.Length; j++)
                {
                    if (allStud[i].mean < allStud[j].mean)
                    {
                        Swap(ref allStud[i], ref allStud[j]);
                    }
                }
            };
        }

        private void Swap(ref NameAndGenMean nameAndGenMean1, ref NameAndGenMean nameAndGenMean2)
        {
            NameAndGenMean temp = nameAndGenMean1;
            nameAndGenMean1 = nameAndGenMean2;
            nameAndGenMean2 = temp;
        }
        private void GroupNameAndGeneralMean(ref NameAndGenMean[] allStud)
        {
            for (int i = 0; i < allStud.Length; i++)
            {
                allStud[i].name = allClass[i].GetStudentName();
                allStud[i].mean = allClass[i].CalculateGeneralMean();
            }
        }

        private struct NameAndGenMean
        {
            public string name;
            public decimal mean;
            public NameAndGenMean(string name,decimal mean)
            {
                this.name = name;
                this.mean = mean;
            }
        }
    }
}
