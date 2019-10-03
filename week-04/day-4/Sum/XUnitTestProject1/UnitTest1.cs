using System;
using Xunit;
using Sum;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public UnitTest1()
        {

        }
        //List<int> someList = new List<int> { 34, 23, 4, 7, 5, 2, 42, 52, 25, 76 };
        Summ sum = new Summ();
        [Fact]
        public void Test1()
        {
            Assert.Equal(270, sum.SumTheNumbersInList(sum.SumList));
        }
        [Theory]
        // [InlineData(new List<int> { 12, 23 })]
        [InlineData(new int[4] { 1, 2, 3, 4 })]
        [InlineData(new int[0])]
        [InlineData(new int[1] {8})]
        public void Test2(int[] array)
        {
            List<int> list = new List<int>(array);
            var output = sum.SumTheNumbersInList(new List<int>(array));
            Assert.Equal(10, output);
            //Assert.Equal(8, output);
            //Assert.Empty(list);
        }
    }
}
