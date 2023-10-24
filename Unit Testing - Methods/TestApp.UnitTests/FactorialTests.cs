using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(1, result);

    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 5;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(120, result);
        
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int input = -8;

        // Act + Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Factorial.CalculateFactorial(input));

    }
}
