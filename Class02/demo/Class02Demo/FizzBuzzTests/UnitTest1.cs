using System;
using Xunit;
using static Class02Demo.Program;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        // Facts are statements
        [Fact]
        public void CanReturn1()
        {
            // Arrange
            // Act

            string fizz = FizzBuzz(1);
            // assert
            Assert.Equal("1", fizz);

        }

        [Fact]
        public void CanReturn2()
        {
            Assert.Equal("2", FizzBuzz(2));

        }

        [Fact]
        public void CanReturnFizzFor3()
        {
            string fizz = FizzBuzz(3);

            Assert.Equal("Fizz", fizz);
        }

        [Fact]
        public void CanReturnBuzzFor5()
        {
            string fizz = FizzBuzz(5);

            Assert.Equal("Buzz", fizz);
        }

        [Fact]
        public void CanReturnFizzFor6()
        {
            string fizz = FizzBuzz(6);

            Assert.Equal("Fizz", fizz);
        }

        [Fact]
        public void CanReturnFizzFor9()
        {
            string fizz = FizzBuzz(9);

            Assert.Equal("Fizz", fizz);
        }

        [Fact]
        public void CanReturnBuzzFor10()
        {
            string fizz = FizzBuzz(10);

            Assert.Equal("Buzz", fizz);
        }

        [Fact]
        public void CanReturnFizzBuzzFor15()
        {
            string fizz = FizzBuzz(15);

            Assert.Equal("FizzBuzz", fizz);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(33)]
        public void CanReturnFizzForThree(int number)
        {
            Assert.Equal("Fizz", FizzBuzz(number));

        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void CanReturnBuzzForFive(int number)
        {
            Assert.Equal("Buzz", FizzBuzz(number));
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(20, "Buzz")]
        
        public void CanPlayFizzBuzz(int number, string expected)
        {
            Assert.Equal(expected, FizzBuzz(number));
        }

        [Fact]
        public void DoesNotReturnBuzzFor15()
        {
            Assert.NotEqual("Buzz", FizzBuzz(15));
        }


    }
}
