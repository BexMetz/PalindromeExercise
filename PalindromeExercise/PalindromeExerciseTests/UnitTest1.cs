using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("noon", true)]
        [InlineData("civic", true)]
        [InlineData("goodbye", false)]
        public void PalindromeTest(string word, bool expected)
        {
            var ws = new WordSmith();
            var actual = ws.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
