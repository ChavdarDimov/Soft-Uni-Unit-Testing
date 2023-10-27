using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string>() { "radar" };

        // Act
        bool isValid = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(isValid);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new ();

        // Act
        bool isValid = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(isValid);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string>() { "civic" };

        // Act
        bool isValid = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(isValid);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new List<string>() { "nope" };

        // Act
        bool isValid = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsFalse(isValid);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string>() { "Rotor", "refer", "12321" };

        // Act
        bool isValid = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(isValid);
    }
}
