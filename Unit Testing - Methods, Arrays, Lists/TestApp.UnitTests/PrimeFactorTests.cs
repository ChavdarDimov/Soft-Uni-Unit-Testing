using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long input = 1;

        // Assert & Act
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long input = 29;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(input);

        // Assert
        Assert.That(result, Is.EqualTo(29));

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long input = 123456789123456789;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(input);

        // Assert
        Assert.That(result, Is.EqualTo(52579));
    }
}
