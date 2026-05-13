using System;
using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;

namespace Datastructures_Unittesting.Sorting;

[TestClass]
public class Selectionsort_testing
{
    [TestMethod]
    public void SelectionSort_SortsArrayInAscendingOrder()
    {
        int[] list = RandomArrayGenerator.Generate();

        Selectionsort.Sort(list);

        for (int i = 0; i < list.Length - 1; i++)
        {
            Assert.IsTrue(list[i] <= list[i + 1]);
        }
    }

    [TestMethod]
    public void SelectionSort_SortsLargeArrayInAscendingOrder()
    {
        int[] list = RandomArrayGenerator.Generate(10000, 0, 1000000000);

        Selectionsort.Sort(list);

        for (int i = 0; i < list.Length - 1; i++)
        {
            Assert.IsTrue(list[i] <= list[i + 1]);
        }
    }

    [TestMethod]
    public void SelectionSort_HandlesEmptyArray()
    {
        Selectionsort.Sort(new int[0]);
        //no error must occur to let the test pass
    }

    [TestMethod]
    public void SelectionSort_HandlesSingleElementArray()
    {
        int singleValue = 230;
        int[] list = new int[] { singleValue };
        Selectionsort.Sort(list);

        Assert.AreEqual(singleValue, list[0]);

    }

    [TestMethod]
    public void SelectionSort_HandlesAlreadySortedArray()
    {
        int[] list = new int[] { 10, 20, 30, 40, 50, 80, 100 };
        int[] clone = (int[])list.Clone();
        Selectionsort.Sort(list);

        CollectionAssert.AreEqual(clone, list);

    }

    [TestMethod]
    public void SelectionSort_HandlesReverseSortedArray()
    {
        int[] list = new int[] { 100, 90, 80, 40, 35, 10, 2 };
        int[] clone = (int[])list.Clone();
        Selectionsort.Sort(list);

        for (int i = clone.Length-1;  i >= 0; i--)
        {
            Assert.AreEqual(clone[i], list[clone.Length - i - 1]);
        }
    }

    [TestMethod]
    public void SelectionSort_HandlesArrayWithDuplicates()
    {
        int[] list = new int[] { 100, 20, 30, 40, 50, 20, 100 };
        Selectionsort.Sort(list);

        for (int i = 0; i < list.Length - 1; i++)
        {
            Assert.IsTrue(list[i] <= list[i + 1]);
        }
    }
}
