using System;
using Xunit;
using Apples;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            
        }

        [Fact]
        public void Test1()
        {          
            //arrange
            var apple = new Apple();
            //assert
            Assert.Equal("apple", apple.GetApple());
        }
    }
}
