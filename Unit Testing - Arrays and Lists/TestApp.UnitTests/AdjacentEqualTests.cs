using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string? expected = AdjacentEqual.Sum(emptyList);

        // Assert
        CollectionAssert.IsEmpty(expected);

    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int>() { 4, 4, 8, 16, 10 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.AreEqual("32 10", result);
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> list = new List<int>() { 4, 4, 8, 16 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.AreEqual("32", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int>() { 4, 4, 10, 16 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.AreEqual("8 10 16", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 4, 6, 6 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.AreEqual("2 4 12", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 4, 4, 6 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.AreEqual("2 8 6", result);
    }
}
