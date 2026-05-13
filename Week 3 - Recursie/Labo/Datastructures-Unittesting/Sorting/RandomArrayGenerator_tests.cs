using System;
using Datastructures_ClassLibrary.Helpers;

namespace Datastructures_Unittesting.Sorting;

[TestClass]
public class RandomArrayGenerator_tests
{

    [TestMethod]
    public void Generate_DefaultParameters_ReturnsArrayWithCorrectLength()
    {
        // Act
        int[] result = RandomArrayGenerator.Generate();

        // Assert
        Assert.AreEqual(10, result.Length);
    }

    [TestMethod]
    public void Generate_WithSpecifiedAmount_ReturnsArrayWithCorrectLength()
    {
        // Act
        int[] result = RandomArrayGenerator.Generate(amount: 5);

        // Assert
        Assert.AreEqual(5, result.Length);
    }

    [TestMethod]
    public void Generate_UniqueNumbers_ReturnsArrayWithNoDuplicates()
    {
        // Act
        int[] result = RandomArrayGenerator.Generate(amount: 10, min: 0, max: 20, unique: true);

        // Assert
        Assert.AreEqual(result.Length, result.Distinct().Count());
    }

    [TestMethod]
    public void Generate_UniqueNumbers_LargeRange_ReturnsCorrectAmount()
    {
        // Act
        int[] result = RandomArrayGenerator.Generate(amount: 50, min: 0, max: 1000, unique: true);

        // Assert
        Assert.AreEqual(50, result.Length);
    }


    [TestMethod]
    public void Generate_MinAndMaxValues_ReturnsNumbersWithinRange()
    {
        // Arrange
        int min = 5;
        int max = 15;

        // Act
        int[] result = RandomArrayGenerator.Generate(amount: 50, min: min, max: max);

        // Assert
        Assert.IsTrue(result.All(num => num >= min && num <= max));
    }

    [TestMethod]
    public void Generate_SingleElementArray_ReturnsCorrectValue()
    {
        // Act
        int[] result = RandomArrayGenerator.Generate(amount: 1, min: 42, max: 42);

        // Assert
        Assert.AreEqual(1, result.Length);
        Assert.AreEqual(42, result[0]);
    }

    [TestMethod]
    public void Generate_EmptyArray_ReturnsEmptyArray()
    {
        // Act
        int[] result = RandomArrayGenerator.Generate(amount: 0);

        // Assert
        Assert.AreEqual(0, result.Length);
    }
}


