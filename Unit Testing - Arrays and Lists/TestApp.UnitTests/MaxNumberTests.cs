using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> list = new() { 6 };

        // Act
        int expectedResult = MaxNumber.FindMax(list);

        //Assert
        int expectedMax = 6;
        Assert.AreEqual(expectedMax, expectedResult);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 10, 20, 30 };

        // Act
        int expectedResult = MaxNumber.FindMax(list);

        //Assert
        int expectedMax = 30;
        Assert.AreEqual(expectedMax, expectedResult);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -10, -20, -30 };

        // Act
        int expectedResult = MaxNumber.FindMax(list);

        //Assert
        int expectedMax = -10;
        Assert.AreEqual(expectedMax, expectedResult);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -10, 20, -30 };

        // Act
        int expectedResult = MaxNumber.FindMax(list);

        //Assert
        int expectedMax = 20;
        Assert.AreEqual(expectedMax, expectedResult);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 30, 20, 30 };

        // Act
        int expectedResult = MaxNumber.FindMax(list);

        //Assert
        int expectedMax = 30;
        Assert.AreEqual(expectedMax, expectedResult);
    }
}
