using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> list = new List<int>() { 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedSum = new List<int>() { 5 };
        CollectionAssert.AreEqual(expectedSum, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 3, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedSum = new List<int>() { 7, 3 };
        CollectionAssert.AreEqual(expectedSum, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int>() { 200, 240, 260, 200 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedSum = new List<int>() { 400, 500 };
        CollectionAssert.AreEqual(expectedSum, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int>() { 200, 240, 260 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expectedSum = new List<int>() { 460, 240 };
        CollectionAssert.AreEqual(expectedSum, result);
    }
}
