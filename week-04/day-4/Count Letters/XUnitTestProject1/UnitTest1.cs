using System;
using Xunit;
using Count_Letters;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Letters letters;
        public UnitTest1()
        {
            letters = new Letters();
        }
        [Theory]
        [InlineData("luky je nejlepsi a terezka taky")]
        public void Test1(string test)
        {
            var originalResult = 
            letters.CountLetters(test);

            Assert.Matches(test);
        }
    }
}
