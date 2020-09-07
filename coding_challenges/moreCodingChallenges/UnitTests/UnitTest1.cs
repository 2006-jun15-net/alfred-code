using System;
using MaximumGap;
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

        [Fact]
        public void TestMaximumGap()
        {
            //arrange
            int[] array = {6,10,1,4};
            Gap gap = new Gap();

            //act on the object
            int actual = gap.MaxGap(array);

            //ascertain on the claim
            Assert.Equal(4, actual);
        }

        [Theory]
        [InlineData(new Object[]{new int[]{9,5,2}, 4})]
        [InlineData(new Object[]{new int[]{100,5,8},92})]
        [InlineData(new Object[]{new int[]{4,-2,1},3})]
        public void TestMaximGapWithMultipleArrays(int[] array, int expectedGap)
        {
            //arrange
            Gap gap = new Gap();

            //act on the object
            int actualGap = gap.MaxGap(array);

            //ascertain on the claim
            Assert.Equal(expectedGap, actualGap);

        }
    }

    
}
