using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        public static void IAmGoingToThrowAnException(string name)
        {
            throw new ArgumentException("I am ERROR");
        }

        [Fact]
        public void Test1()
        {
            //Assert.Throws<ArgumentException>(IAmGoingToThrowAnException);
            Assert.Throws<Exception>(() => IAmGoingToThrowAnException("Amanda"));
        }
    }
}
