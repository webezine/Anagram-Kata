using Xunit;
using AnagramConsole.Models.ExtensionMethods;
using FluentAssertions;

namespace Model.Tests
{
    public class StringExtensionMethodsReverseStringTests
    {


        [Fact]
        public void ReverseString_Should_Return_String()
        {
            // Arrange
            var word = "bat";

            // Act
            var reverseResult = word.ReverseString();

            // Assert
            reverseResult.Should().BeOfType<string>();
        }

        [Fact]
        public void ReverseString_Should_Return_ReverseOfString()
        {
            // Arrange
            var word = "bat";

            // Act
            var reverseResult = word.ReverseString();

            // Assert
            reverseResult.Should().Be("tab", "because this is the reverse of bat.");
        }

        [Fact]
        public void ReverseString_Should_Not_ChangeCase()
        {
            // Arrange
            var word = "bAt";

            // Act
            var reverseResult = word.ReverseString();

            // Assert
            reverseResult.Should().Be("tAb", "because this is the reverse of bat.");
        }

        [Fact]
        public void ReverseString_Should_Not_ChangeLength()
        {
            // Arrange
            var word = "bAt";

            // Act
            var reverseResult = word.ReverseString();

            // Assert
            reverseResult.Length.Should().Be(word.Length, "because this is the char length of the original string.");
        }

        [Fact]
        public void ReverseString_Should_HandleEmptyString()
        {
            // Arrange
            var word = string.Empty;

            // Act
            var reverseResult = word.ReverseString();

            // Assert
            reverseResult.Should().Be(word, "because empty strings shouldnt cause problems");
        }

        [Fact]
        public void ReverseString_Should_HandleInt()
        {
            // Arrange
            var word = "123";

            // Act
            var reverseResult = word.ReverseString();

            // Assert
            reverseResult.Should().Be("321", "because numbers are people too!");
        }

    }
}
