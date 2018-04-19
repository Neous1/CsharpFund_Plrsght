using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBooks
    {
        public GradeBooks()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //use list from the collection to store grades

        List<float> grades;

        public GradeStatistics CommputeStatistics()
        {
            //create a variable to point to the new instance of 
            //GradeStatistic
            GradeStatistics stats =  new GradeStatistics();

            stats.HighestGrade = 0;

            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade; 
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
    }
}
