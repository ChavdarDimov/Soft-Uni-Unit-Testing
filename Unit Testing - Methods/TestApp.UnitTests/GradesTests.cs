using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2, "Fail")]
    [TestCase(3, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(4, "Very Good")]
    [TestCase(4.50, "Excellent")]

    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(0, "Invalid!")]
    [TestCase(-9, "Invalid!")]
    [TestCase(999, "Invalid!")]
    [TestCase(-6, "Invalid!")]
    [TestCase(40, "Invalid!")]

    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
