using System;
using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;

namespace Datastructures_Unittesting.Sorting;

[TestClass]
public class Insertionsort_testing
{

    [TestMethod]
    public void InsertionSort_SortsArrayInAscendingOrder()
    {
        // Arrange
        int[] input = [5, 1, 3, 2, 4];
        int[] expected = [5, 4, 3, 2, 1];

        // Act
        Insertionsort.Sort(input);

        // Assert
        CollectionAssert.AreEqual(expected, input);
    }

    [TestMethod]
    public void InsertionSort_SortsLargeArrayInAscendingOrder()
    {
        // Arrange
        int[] input = RandomArrayGenerator.Generate(10000, 0, 10000000); ;

        // Act
        Insertionsort.Sort(input);

        // Assert
        for (int i = 0; i < input.Length-1; i++)
        {
            Assert.IsTrue(input[i] >= input[i + 1]);
        }
    }

    [TestMethod]
    public void InsertionSort_HandlesEmptyArray()
    {
        int[] input = new int[0];
        Insertionsort.Sort(input);

        //No error must occur for the test to pass

    }

    [TestMethod]
    public void InsertionSort_HandlesSingleElementArray()
    {
        int singleValue = 230;
        int[] list = new int[] { singleValue };
        Insertionsort.Sort(list);

        Assert.AreEqual(singleValue, list[0]);

    }

    [TestMethod]
    public void InsertionSort_HandlesAlreadySortedArray()
    {
        int[] list = new int[] { 100, 90, 80, 40, 35, 10, 2 };
        int[] clone = (int[])list.Clone();
        Insertionsort.Sort(list);

        CollectionAssert.AreEqual(clone, list);
    }

    [TestMethod]
    public void InsertionSort_HandlesReverseSortedArray()
    {
        int[] list = new int[] { 10, 20, 30, 40, 50, 80, 100 };
        int[] clone = (int[])list.Clone();
        Insertionsort.Sort(list);

        for (int i = clone.Length - 1; i >= 0; i--)
        {
            Assert.AreEqual(clone[i], list[clone.Length - i - 1]);
        }
    }

    [TestMethod]
    public void InsertionSort_HandlesArrayWithDuplicates()
    {
        int[] list = new int[] { 100, 20, 30, 40, 50, 20, 100 };
        Insertionsort.Sort(list);

        for (int i = 0; i < list.Length - 1; i++)
        {
            Assert.IsTrue(list[i] >= list[i + 1]);
        }
    }

    [TestMethod]
    public void InsertionSort_HandlesLargeArrayWithDuplicates()
    {
        int[] list = RandomArrayGenerator.Generate(20000, 0, 30000, true);
        Insertionsort.Sort(list);

        for (int i = 0; i < list.Length - 1; i++)
        {
            Assert.IsTrue(list[i] >= list[i + 1]);
        }
    }

}
