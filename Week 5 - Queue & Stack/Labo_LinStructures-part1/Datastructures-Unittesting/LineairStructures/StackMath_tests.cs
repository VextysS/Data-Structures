using Datastructures_ClassLibrary.LineairStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.LineairStructures
{
    [TestClass]
    public class StackMath_tests
    {
        [DataTestMethod]
        [DataRow("7+(x∗3)")]
        [DataRow("[28 * (9 + 3) - 30]")]
        public void TestCorrectFormula(string formula)
        {
            Assert.IsTrue(StackMath.EvaluateFormula(formula));
        }

        [DataTestMethod]
        [DataRow("7+(x∗3")]
        [DataRow("7+(x∗3))")]
        [DataRow("[28 * (9 + 3) - 30)")]
        [DataRow("[28 * (9 + 3] - 30)")]
        public void TestIncorrectFormula(string formula)
        {
            Assert.IsFalse(StackMath.EvaluateFormula(formula));
        }
    }
}
