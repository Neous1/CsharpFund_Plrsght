using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBooks
    {
        public GradeBooks()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            //create a variable to point to the new instance of 
            //GradeStatistic
            GradeStatistics stats = new GradeStatistics();

            stats.HighestGrade = 0;

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrades = Math.Min(grade, stats.LowestGrades);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //use list from the collection to store grades

        private List<float> grades;


    }
}
