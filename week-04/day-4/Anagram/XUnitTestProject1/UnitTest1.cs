using System;
using Xunit;
using Anagram;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("lukas","kaslu")]
        [InlineData("FAJKH","FAFAvv")]
        [InlineData("kolobezka","bezkakolo")]
        public void Test1(string firstWord, string secondWord)
        {
            var test = new BoolAnagram();
            Assert.True(test.IsAnagram(firstWord, secondWord));
            //Assert.False(test.IsAnagram(firstWord, secondWord));
        }
    }
}
