using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    class Program
    {

        static void Main(string[] args)
        {
            GradeBooks g1 = new GradeBooks();
            GradeBooks g2 = g1;

            g1.Name = "Yvon's grade book";
            Console.WriteLine(g2.Name);
            //GradeBooks book = new GradeBooks(); //define a variable book of type Gradbooks
            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine("Average Grade: " + stats.AverageGrade);
            //Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            //Console.WriteLine("Lowest Grade: " +  stats.LowestGrades);




        }
    }

}
