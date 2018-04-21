using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void VariableHoldAReference()
        {
            GradeBooks g1 = new GradeBooks();
            GradeBooks g2 = g1;

            g1.Name = "Yvon's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        
        }
    }
}
