using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Recursion.Tests
{
    [TestClass()]
    public class CalculateFactorialTests
    {
        [TestMethod()]
        public void CalculateFactorialOefTest()
        {
            //Arrange
            int factualNumber = 5;

            //Act
            int result = CalculateFactorial.CalculateFactorialoef(factualNumber);

            Assert.AreEqual(120, result);

        }
    }
}