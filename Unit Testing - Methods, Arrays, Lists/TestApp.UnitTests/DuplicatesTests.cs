using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        CollectionAssert.AreEqual(result, numbers);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] arr = new int[] { 1, 2, 3, 4, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(arr);

        // Assert
        Assert.That(result, Is.EqualTo(arr));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] arr = new int[] { 1, 2, 2, 4, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(arr);

        // Assert
        Assert.AreEqual(new int[] { 1, 2, 4, 5 }, result);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] arr = new int[] { 1, 1, 1, 1, 1 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(arr);

        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 1 }));
        
    }
}
