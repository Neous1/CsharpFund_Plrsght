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

            book.NameChanged += new  NameChangedDelegate(OnNameChanged);
            book.NameChanged += new  NameChangedDelegate(OnNameChanged2);
            book.Name = "Yvon's Grade book";
            book.Name = "Grade book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Average Grade" , stats.AverageGrade);
            WriteResult("Highest Grade" , (int)stats.HighestGrade); //stats highestGrade gets coerces into type int
            WriteResult("Lowest Grade" , stats.LowestGrades);
        }

        private static void OnNameChanged(string existingname, string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingname} to {newName}");
        }

        private static void OnNameChanged2(string existingname, string newName)
        {
            Console.WriteLine("***");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            //Console.WriteLine(description + ": " + result);
            //Console.WriteLine("{0}: {1}", description, result);
            //Console.WriteLine($"{description}: {result}", description, result);
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }
    }

}

