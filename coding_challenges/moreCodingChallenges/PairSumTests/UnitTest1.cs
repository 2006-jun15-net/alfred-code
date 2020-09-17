using System;
using PairSumProgram;
using Xunit;

namespace PairSumTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyArray()
        {
            //arrange
            FindPairSum findPairSum = new FindPairSum();
            int[] array = {};
            int k = 3;

            //act
            findPairSum.CountPairSum(array, k);

            //assert

            

        }

        [Theory]
        [InlineData(new int[]{1,9,2,8,3,7,4,6,5,5,13,14,11,13,-1}, 10, 6)]
        [InlineData(new int[]{1,2,3,1}, 3, 1)]
        [InlineData(new int[]{1,3,2,2}, 4, 2)]
        public void TestPairSum(int[] array, int k, int ExpectedCount)
        {
            //arrange 
            FindPairSum findPair = new FindPairSum();

            //act
            int actualCount = findPair.CountPairSum(array, k);

            //assert
            Assert.Equal(ExpectedCount, actualCount);

        }
    }
}
