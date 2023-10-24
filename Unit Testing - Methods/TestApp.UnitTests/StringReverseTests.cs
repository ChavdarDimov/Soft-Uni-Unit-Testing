using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", result); 
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "C";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("C", result);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "Test";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("tseT", result);
    }
}
