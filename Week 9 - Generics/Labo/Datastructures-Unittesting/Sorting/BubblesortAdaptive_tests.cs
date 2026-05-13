using System;
using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;

namespace Datastructures_Unittesting.Sorting;


[TestClass]
public class BubbleSortAdaptive_tests
{
    [TestMethod]
    public void BubbleSortAdaptive_SortsArrayInAscendingOrder()
    {
        // Arrange
        int[] input = [ 5, 1, 3, 2, 4 ];
        int[] expected = [ 1, 2, 3, 4, 5 ];

        // Act
        Bubblesort.SortAdaptive(input);

        // Assert
        CollectionAssert.AreEqual(expected, input);
    }

    [TestMethod]
    public void BubbleSortAdaptive_SortsLargeArrayInAscendingOrder()
    {
        // Arrange
        int[] input = RandomArrayGenerator.Generate(1000, 1, 100000, false);

        // Act
        Bubblesort.SortAdaptive(input);

        // Assert
        for (int i = 0; i < input.Length - 1; i++)
        {
            Assert.IsTrue(input[i] <= input[i + 1]);
        }
    }

    [TestMethod]
    public void BubbleSortAdaptive_HandlesEmptyArray()
    {
        // Arrange
        int[] input = [];

        //If nothing goes wrong here the test is successfull
        Bubblesort.SortAdaptive(input);
    }

    [TestMethod]
    public void BubbleSortAdaptive_HandlesSingleElementArray()
    {
        // Arrange
        int[] input = [42];
        int[] expected = [42];

        Bubblesort.SortAdaptive(input);

        Assert.AreEqual(expected[0], input[0]);
    }

    [TestMethod]
    public void BubbleSortAdaptive_HandlesAlreadySortedArray()
    {
           // Arrange
        int[] input = [ 1, 2, 3, 4, 5 ];
        int[] expected = [ 1, 2, 3, 4, 5 ];

        // Act
        Bubblesort.SortAdaptive(input);

        // Assert
        CollectionAssert.AreEqual(expected, input);
    }

    [TestMethod]
    public void BubbleSortAdaptive_HandlesReverseSortedArray()
    {
            // Arrange
        int[] input = [ 5, 4, 3, 2, 1 ];
        int[] expected = [ 1, 2, 3, 4, 5 ];

        // Act
        Bubblesort.SortAdaptive(input);

        // Assert
        CollectionAssert.AreEqual(expected, input);
    }

    [TestMethod]
    public void BubbleSortAdaptive_HandlesArrayWithDuplicates()
    {
            // Arrange
        int[] input = [ 5, 4, 4, 3, 5 ];
        int[] expected = [ 3, 4, 4, 5, 5 ];

        // Act
        Bubblesort.SortAdaptive(input);

        // Assert
        CollectionAssert.AreEqual(expected, input);
    }
}


