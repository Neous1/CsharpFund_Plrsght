using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    class GradeBooks
    {
        //HOld State adn Behavior

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //use list from the collection to store grades

        List<float> grades = new List<float>(); // use the paren becz a new2 list object is constructed.

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
