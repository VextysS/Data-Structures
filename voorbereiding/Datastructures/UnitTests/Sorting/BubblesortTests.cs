using Examen_voorbereiding.Helpers;
using Examen_voorbereiding.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_voorbereiding.Sorting.Tests
{
    [TestClass]
    public class Bubblesort_tests
    {
        [TestMethod]
        public void Bubblesort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = [5, 2, 9, 1, 5, 6];
            int[] expected = [1, 2, 5, 5, 6, 9];

            // Act
            //Bubblesort.Sort(input);
            Bubblesort.SortAdaptive(input);

            // Assert
            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
            //or use this easier solution to compare both arrays
            //CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Bubblesort_SortsLargeArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(100000, 1, 100000, false);

            // Act
            Bubblesort.Sort(input);

            // Assert
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }
        }

        [TestMethod]
        public void Bubblesort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = [];
            int[] expected = [];

            // TODO: put here your test code
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Bubblesort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = [42];
            int[] expected = [42];

            // TODO: put here your test code
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Bubblesort_HandlesAlreadySortedArray()
        {
            // TODO: put here your test code
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Bubblesort_HandlesReverseSortedArray()
        {
            // TODO: put here your test code
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Bubblesort_HandlesArrayWithDuplicates()
        {
            // TODO: put here your test code
            throw new NotImplementedException();
        }
    }
}