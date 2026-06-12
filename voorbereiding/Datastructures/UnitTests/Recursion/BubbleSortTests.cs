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
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortRecursiveTest()
        {
            // Arrange
            int[] input = [5, 2, 9, 1, 5, 6];
            int[] expected = [1, 2, 5, 5, 6, 9];

            BubbleSort.SortRecursive(input, input.Length);

            CollectionAssert.AreEqual(expected,input);
        }
    }
}