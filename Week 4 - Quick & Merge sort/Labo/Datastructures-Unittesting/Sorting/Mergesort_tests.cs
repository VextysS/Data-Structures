using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;

namespace Datastructures_Unittesting.Sorting
{
    [TestClass]
    public class Mergesort_tests
    {
        [TestMethod]
        public void Mergesort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = [5, 1, 3, 2, 4];
            int[] expected = [1, 2, 3, 4, 5];

            // Act
            Mergesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Mergesort_SortsLargeArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(100000, 1, 100000, false);

            // Act
            Mergesort.Sort(input);

            // Assert
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }
        }

        [TestMethod]
        public void Mergesort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = [];

            //If nothing goes wrong here the test is successfull
            Mergesort.Sort(input);
        }

        [TestMethod]
        public void Mergesort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = [42];
            int[] expected = [42];

            Mergesort.Sort(input);

            Assert.AreEqual(expected[0], input[0]);
        }

        [TestMethod]
        public void Mergesort_HandlesAlreadySortedArray()
        {
            // Arrange
            int[] input = [1, 2, 3, 4, 5];
            int[] expected = [1, 2, 3, 4, 5];

            // Act
            Mergesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Mergesort_HandlesReverseSortedArray()
        {
            // Arrange
            int[] input = [5, 4, 3, 2, 1];
            int[] expected = [1, 2, 3, 4, 5];

            // Act
            Mergesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Mergesort_HandlesArrayWithDuplicates()
        {
            // Arrange
            int[] input = [5, 4, 4, 3, 5];
            int[] expected = [3, 4, 4, 5, 5];

            // Act
            Mergesort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
