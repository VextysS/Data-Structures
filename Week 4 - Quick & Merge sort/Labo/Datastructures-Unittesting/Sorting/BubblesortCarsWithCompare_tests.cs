using System;
using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;

namespace Datastructures_Unittesting.Sorting;

[TestClass]
public class BubbleSortCarsWithCompare_tests
{
    

    [TestMethod]
    public void SortsLargeArrayInAscendingOrder()
    {
        // Arrange
        Car[] input = RandomArrayGenerator.GenerateCars(10000);

        // Act
        Bubblesort.Sort(input);

        // Assert
        for (int i = 0; i < input.Length - 1; i++)
        {
            //Check if cars were sorted by Year descending
            Assert.IsTrue(input[i].Year >= input[i + 1].Year);
            if (input[i].Year == input[i + 1].Year)
            {
                //cars with same year are sorted by kilomenters ascending
                Assert.IsTrue(input[i].Kilometers <= input[i + 1].Kilometers);
            }
        }
    }
}

