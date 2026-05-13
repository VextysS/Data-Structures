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
    public class QuickSortDoubles_tests
    {
        [TestMethod]
        public void QuickSortDoubles_SortsArrayInAscendingOrder()
        {
            // Arrange
            double[] input = [5.2, 1.1, 3.9, 2.2, 4.4];
            double[] expected = [1.1, 2.2, 3.9, 4.4, 5.2];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSortDoubles_HandlesEmptyArray()
        {
            // Arrange
            double[] input = [];

            //If nothing goes wrong here the test is successfull
            Quicksort.Sort(input);
        }

        [TestMethod]
        public void QuickSortDoubles_HandlesSingleElementArray()
        {
            // Arrange
            double[] input = [42];
            double[] expected = [42];

            Quicksort.Sort(input);

            Assert.AreEqual(expected[0], input[0]);
        }

        [TestMethod]
        public void QuickSortDoubles_HandlesAlreadySortedArray()
        {
            // Arrange
            double[] input = [1, 2, 3, 4, 5];
            double[] expected = [1, 2, 3, 4, 5];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSortDoubles_HandlesReverseSortedArray()
        {
            // Arrange
            double[] input = [5, 4, 3, 2, 1];
            double[] expected = [1, 2, 3, 4, 5];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSortDoubles_HandlesArrayWithDuplicates()
        {
            // Arrange
            double[] input = [5, 4, 4, 3, 5];
            double[] expected = [3, 4, 4, 5, 5];

            // Act
            Quicksort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
