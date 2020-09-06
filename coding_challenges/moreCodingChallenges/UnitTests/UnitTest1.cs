using System;
using PrimeCheck;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestingIfNumberIsPrime()
        {
            //Arrange: setting up the object to be tested
            IsPrime primeCheck = new IsPrime();

            //Act: Act on the object by invoking a method on the object
            bool cond = primeCheck.isPrime(6);
            bool cond2 = primeCheck.isPrime(5);

            //Assert: make claims about the object
            Assert.False(cond);
            Assert.True(cond2);

        }

        [Theory]
        [InlineData(0,false)]
        [InlineData(1, false)]
        [InlineData(7, true)]
        [InlineData(10, false)]
        [InlineData(-2, false)]
        public void TestingMultipleNumbers(int number, bool expectedValue)
        {
            //arrange
            IsPrime prime = new IsPrime();

            //Act on the object
            bool cond = prime.isPrime(number);

            //Ascertain on the claim
            Assert.Equal(expectedValue, cond);
        }
    }
}
