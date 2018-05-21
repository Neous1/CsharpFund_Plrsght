using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    class Program
    {

        static void Main(string[] args)
        {

            GradeBook book = new GradeBook(); 
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Average Grade" , stats.AverageGrade);
            WriteResult("Highest Grade" , stats.HighestGrade); //stats highestGrade gets coerces into type int
            WriteResult("Lowest Grade" , stats.LowestGrades);
            WriteResult(stats.Description, stats.LetterGrade);
        }



        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }
    }

}

