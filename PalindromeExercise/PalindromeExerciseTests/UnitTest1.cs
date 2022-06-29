using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("Car", false)]
        public void PalidromeTester(string word, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);



        }
    }
}
