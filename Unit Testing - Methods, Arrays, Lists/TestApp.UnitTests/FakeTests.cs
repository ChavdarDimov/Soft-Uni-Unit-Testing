using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { '1', '2', 'a', 'b', 'c' };

        // Act
        Fake.RemoveStringNumbers(input);
        char[] expected = new char[] { 'a', 'b', 'c' };

        // Assert
        CollectionAssert.AreEqual(expected, Fake.RemoveStringNumbers(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] { 'a', 'b', 'c' };

        // Act
        Fake.RemoveStringNumbers(input);
        char[] expected = new char[] { 'a', 'b', 'c' };

        // Assert
        CollectionAssert.AreEqual(expected, Fake.RemoveStringNumbers(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[] { };

        // Act
        Fake.RemoveStringNumbers(input);
        char[] expected = new char[] { };

        // Assert
        CollectionAssert.AreEqual(expected, Fake.RemoveStringNumbers(input));
    }
}
