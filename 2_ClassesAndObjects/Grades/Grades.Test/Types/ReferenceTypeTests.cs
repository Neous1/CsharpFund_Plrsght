using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            // number is equal to 46 because the value of x is passed to IncrementNumber
           number += 1; // number +1 is inconsequential to our test.
        }
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBooks book1 = new GradeBooks();
            GradeBooks books2 = book1;

            GiveBookAName(books2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveBookAName(GradeBooks book)
        {
            book.Name = "A Gradebook";
        }
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Yvon";
            string name2 = "yvon";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        } 
        [TestMethod]
        public void GradeBookVariableHoldAReference()
        {
            GradeBooks g1 = new GradeBooks();
            GradeBooks g2 = g1;

            g1 = new GradeBooks(); // g1 now points to a new gradebook but g2 still points to the old gradebook so g1 is not equal to g2.


            g1.Name = "Yvon's grade book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        
        }
    }
}
