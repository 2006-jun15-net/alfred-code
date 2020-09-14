using System;
using OccurenceArray;
using Xunit;

namespace occurenceArray.Tests
{
    public class UnitTest1
    {
        

        [Theory]
        [InlineData(new int[]{1,1,2,3,1}, 1, 3)]
        [InlineData(new int[]{1,1,2,3,1}, 2, 1)]
        [InlineData(new int[]{4,4,4,4,4}, 4, 5)]
        [InlineData(new int[]{3,5,6,78,90,3,2}, 3, 2)]
        [InlineData(new int[]{2,3,4}, 9, 0)]
        public void TestingOccurenceInArray(int[] array, int targetNumber, int ExpectedNumber)
        {
            //arrange
            Occurence occurence = new Occurence();

            //act
            int actualFreq = occurence.FindFrequency(array,targetNumber);

            //assert
            Assert.Equal(ExpectedNumber, actualFreq);

        }
    }
}
