﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public void CheckingLetterGrade()
        {
            float grade;
            CheckGrades(54.7f);
            Assert.IsTrue(true,"A");
            // return result;
        }

        private string CheckGrades(float grades)
        {
            float grade = 54.7f;
            string result;

            if (grade >= 90)
            {
                result = "A";
            }
            else if (grade >= 80)
            {
                result = "B";
            }
            else if (grade >= 70)
            {
                result = "C";
            }
            else if (grade >= 60)
            {
                result = "D";
            }
            else
            {
                result = "F";
            }

            return result;

        }

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]); 
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "yvon";
            name = name.ToUpper();

            Assert.AreEqual("YVON", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 4, 25);
            date = date.AddDays(1);

            Assert.AreEqual(26, date.Day);
        }

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
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2);
            Assert.AreEqual("A Gradebook", book2.Name); // test fails cuz book2's name is null 
        }

        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
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
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook(); // g1 now points to a new gradebook but g2 still points to the old gradebook so g1 is not equal to g2.


            g1.Name = "Yvon's grade book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        
        }
    }
}
