using AnagramConsole.Models.ExtensionMethods;
using FluentAssertions;
using Xunit;

namespace Model.Tests
{

    public class StringExtensionMethodsIsAnAnagramTests
    {
        [Fact]
        public void IsAnAnagram_Should_Return_False_When_LengthsDiffer()
        {
            // Arrange
            var wordOne = "testing";
            var wordTwo = "test";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeFalse("because the string length differs");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_False_When_WordsMatch()
        {
            // Arrange
            var wordOne = "testing";
            var wordTwo = "testing";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeFalse("because the strings are the same and are not technically an anagram.");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram()
        {
            // Arrange
            var wordOne = "bat";
            var wordTwo = "tab";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams.");
        }


        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram_RegardlessOfCase_Sc1()
        {
            // Arrange
            var wordOne = "bat";
            var wordTwo = "TAB";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams regardless of their caps case.");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram_RegardlessOfCase_Sc2()
        {
            // Arrange
            var wordOne = "BAT";
            var wordTwo = "tab";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams regardless of their caps case.");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram_RegardlessOfCase_Sc3()
        {
            // Arrange
            var wordOne = "BAT";
            var wordTwo = "TAB";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams regardless of their caps case.");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram_EvenWhen_SameWord()
        {
            // Arrange
            var wordOne = "Aibohphobia";
            var wordTwo = "Aibohphobia";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams. - same chars backwards & forwards");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram_EvenWhen_WhiteSpace_Sc1()
        {
            // Arrange
            var wordOne = "Aibohphobia "; // Deliberate white space. Do not remove.
            var wordTwo = "Aibohphobia";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams - regardless of whitespace.");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram_EvenWhen_WhiteSpace_Sc2()
        {
            // Arrange
            var wordOne = "Aibohphobia"; // Deliberate white space. Do not remove.
            var wordTwo = "Aibohphobia ";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams - regardless of whitespace.");
        }

        [Fact]
        public void IsAnAnagram_Should_Return_True_When_WordsAreAnAnagram_EvenWhen_WhiteSpace_Sc3()
        {
            // Arrange
            var wordOne = " Aibohphobia"; // Deliberate white space. Do not remove.
            var wordTwo = "Aibohphobia ";

            // Act
            var sutResult = wordOne.IsAnAnagram(wordTwo);

            // Assert 
            sutResult.Should().BeTrue("because the words are anagrams - regardless of whitespace.");
        }
    }
}
