using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    class Program
    {

        static void Main(string[] args)
        {

           SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is Yvon's grade book program");

            GradeBooks book = new GradeBooks(); //define a variable book of type Gradbooks
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " +  stats.LowestGrades);



            
        }
    }

}
