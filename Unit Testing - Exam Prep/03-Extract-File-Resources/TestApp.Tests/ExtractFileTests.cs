using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = string.Empty;

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "D:\\Games\\Cyberpunk 2077\\REDprelauncher.exe";

        // Act
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo("File name: REDprelauncher\nFile extension: exe"));

    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = "D:\\Games\\Cyberpunk 2077\\REDprelauncher";

        // Act
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo("File name: REDprelauncher"));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "D:\\Games\\Cyberpunk 2077!\\REDprelauncher.exe";

        // Act
        string output = ExtractFile.GetFile(path);

        // Assert
        Assert.That(output, Is.EqualTo("File name: REDprelauncher\nFile extension: exe"));
    }
}
