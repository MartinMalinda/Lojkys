using System;
using Xunit;
using Sum;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        List<int> someList = new List<int> { 34, 23, 4, 7, 5, 2, 42, 52, 25, 76 };
        Summ sum = new Summ();
        [Fact]
        public void Test1()
        {
            Assert.Equal(270, sum.SumTheNumbersInList(sum.sumList));
        }
    }
}
