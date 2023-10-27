using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        //Arrange
        int n = 0;

        // Act
        int expected = Fibonacci.CalculateFibonacci(n);

        //Assert
        Assert.That(expected, Is.EqualTo(n));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int n = 5;

        // Act
        int expected = Fibonacci.CalculateFibonacci(n);

        //Assert
        Assert.That(expected, Is.EqualTo(5));
    }
}