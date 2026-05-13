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
    public class BubbleSortDoubles_tests
    {
        [TestMethod]
        public void BubbleSortDoubles_SortsArrayInAscendingOrder()
        {
            // Arrange
            double[] input = [5.2, 1.1, 3.9, 2.2, 4.4];
            double[] expected = [1.1, 2.2, 3.9, 4.4, 5.2];

            // Act
            Bubblesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSortDoubles_HandlesEmptyArray()
        {
            // Arrange
            double[] input = [];

            //If nothing goes wrong here the test is successfull
            Bubblesort.Sort(input);
        }

        [TestMethod]
        public void BubbleSortDoubles_HandlesSingleElementArray()
        {
            // Arrange
            double[] input = [42];
            double[] expected = [42];

            Bubblesort.Sort(input);

            Assert.AreEqual(expected[0], input[0]);
        }

        [TestMethod]
        public void BubbleSortDoubles_HandlesAlreadySortedArray()
        {
            // Arrange
            double[] input = [1, 2, 3, 4, 5];
            double[] expected = [1, 2, 3, 4, 5];

            // Act
            Bubblesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSortDoubles_HandlesReverseSortedArray()
        {
            // Arrange
            double[] input = [5, 4, 3, 2, 1];
            double[] expected = [1, 2, 3, 4, 5];

            // Act
            Bubblesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSortDoubles_HandlesArrayWithDuplicates()
        {
            // Arrange
            double[] input = [5, 4, 4, 3, 5];
            double[] expected = [3, 4, 4, 5, 5];

            // Act
            Bubblesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
