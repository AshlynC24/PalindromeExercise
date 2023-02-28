using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("Hello", false)]
        [InlineData("bed",false)]
        [InlineData("hanah",true)]
        [InlineData("anna",true)]
        [InlineData("Dog", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            //act
            var actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
