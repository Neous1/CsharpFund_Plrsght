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
    }

    class Program
    {
        static void Main(string[] args)
        {
            GradeBooks book=new GradeBooks(); //define a variable book of type Gradbooks
            book.AddGrade(91);
            book.AddGrade(89.5f);
        }
    }

}
