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
            GradeBooks book=new GradeBooks(); //define a variable book of type Gradbooks
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeBooks book2 = book;
            book2.AddGrade(75);
        }
    }

}
