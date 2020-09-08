using System;
using Xunit;

namespace Anagram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckLengthOfStrings()
        {
            //arrange
            AnagramCheck.Anagram anagram = new AnagramCheck.Anagram();

            //act
            bool cond = anagram.CheckAnagram("boston", "celtics");

            //assert
            Assert.False(cond);

        }
        [Theory]
        [InlineData("anagram", "gramana",true)]
        [InlineData("inn", "nin",true)]
        [InlineData("rules", "rule",false)]
        [InlineData("lakers", "lacers",false)]
        
        public void TestCheckingIfStringsAreAnagrams(string s1, string s2, bool expectedBool)
        {
            //arrange 
            AnagramCheck.Anagram anagram = new AnagramCheck.Anagram();

            //act
            bool actualCond = anagram.CheckAnagram(s1,s2);

            //assert
            Assert.StrictEqual(expectedBool, actualCond);




        }
        
        [Fact]
        public void TestingSortingMethod()
        {
            //arrange 
            AnagramCheck.Anagram anagram = new AnagramCheck.Anagram();
            string s = "anagram";

            //Act
            string actualSorted = anagram.sortedString(s);

            //assert
            Assert.Equal("aaagmnr", actualSorted);


        }

        [Theory]
        [InlineData("love","elov")]
        [InlineData("diana", "aadin")]
        [InlineData("peter","eeprt")]
        [InlineData("right","ghirt")]
        public void TestingMoreCases(string s, string ExpectedString)
        {
            //arrange
            AnagramCheck.Anagram anagram = new AnagramCheck.Anagram();

            //act
            string actualString = anagram.sortedString(s);

            //assert
            Assert.Equal(ExpectedString, actualString);

        }

        
    }
}
