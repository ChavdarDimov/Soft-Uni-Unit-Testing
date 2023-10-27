using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] array = new[] { 2, 4, 6, 8 };

        // Act
        int result = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnOddSum()
    {
        // Arrange
        int[] array = new[] { 3, 5, 7 };

        // Act
        int result = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] array = new[] { 2, 5, 4, 10, 5 };

        // Act
        int result = EvenOddSubtraction.FindDifference(array);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }
}
