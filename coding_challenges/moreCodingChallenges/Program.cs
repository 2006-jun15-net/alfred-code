using System;
using MaximumGap;
using PrimeCheck;
using AnagramCheck;
using OccurenceArray;
using PairSumProgram;

namespace moreCodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array = {3,6,9,1,35};
            // Gap gap = new Gap();
            // System.Console.WriteLine(gap.MaxGap(array));

            // //IsPrime primeCheck = new IsPrime();
            //System.Console.WriteLine(primeCheck.isPrime(-2));

            // AnagramCheck.Anagram anagram = new AnagramCheck.Anagram();
            // string s1 = "bca";
            // string s2 = "cba";
            // System.Console.WriteLine(anagram.CheckAnagram(s1,s2));

            // Occurence occurence = new Occurence();
            // int[] array = {3,4,5,4,8,-1};
            // System.Console.WriteLine(occurence.FindFrequency(array,4));

            FindPairSum findPair = new FindPairSum();
            int[] array = {1,3,2,2};
            System.Console.WriteLine(findPair.CountPairSum(array,4));

            
            

            

            

            


            
            
        }

        
        
       
    }
}
