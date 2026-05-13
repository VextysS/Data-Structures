using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Sorting
{
    [TestClass]
    public class Quicksort_tests
    {
        [TestMethod]
        public void Quicksort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = [5, 1, 3, 2, 4];
            int[] expected = [1, 2, 3, 4, 5];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Quicksort_SortsLargeArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(100000, 1, 100000, false);

            // Act
            Quicksort.Sort(input);

            // Assert
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }
        }

        [TestMethod]
        public void Quicksort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = [];

            //If nothing goes wrong here the test is successfull
            Quicksort.Sort(input);
        }

        [TestMethod]
        public void Quicksort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = [42];
            int[] expected = [42];

            Quicksort.Sort(input);

            Assert.AreEqual(expected[0], input[0]);
        }

        [TestMethod]
        public void Quicksort_HandlesAlreadySortedArray()
        {
            // Arrange
            int[] input = [1, 2, 3, 4, 5];
            int[] expected = [1, 2, 3, 4, 5];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Quicksort_HandlesReverseSortedArray()
        {
            // Arrange
            int[] input = [5, 4, 3, 2, 1];
            int[] expected = [1, 2, 3, 4, 5];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Quicksort_HandlesArrayWithDuplicates()
        {
            // Arrange
            int[] input = [5, 4, 4, 3, 5];
            int[] expected = [3, 4, 4, 5, 5];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
