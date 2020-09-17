using System;
using MaximumGap;
using PrimeCheck;
using AnagramCheck;
using OccurenceArray;
using PairSumProgram;
using RemoveDuplicates;
using System.Collections.Generic;

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

            // FindPairSum findPair = new FindPairSum();
            // int[] array = {1,3,2,2};
            // System.Console.WriteLine(findPair.CountPairSum(array,4));

            // StringDuplicate stringDuplicate = new StringDuplicate();
            // string str = "looooove";
            // System.Console.WriteLine(stringDuplicate.RemoveDuplicateString(str));

            //int[] array = {1,2,3,4,5,6,7,8,9};
            //System.Console.WriteLine(findMissingNumber(array,1,10));

            //string s = "love";
            
            //System.Console.WriteLine(CheckUnique(s));

            int num = 34431;
            System.Console.WriteLine(checkPalindromic(num));



            
        }
        /// <summary>
        /// returns the missing number in an array of a starting to ending integer.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>

        public static int findMissingNumber(int[] array, int start, int end)
        {
            int missingNumber = 0;
            foreach(int num in array)
            {
                for(int i = start; i <= end; i++)
                {
                    if(i != num)
                    {
                        missingNumber = i;
                    }

                }
            }return missingNumber;
        }

        /// <summary>
        /// checks if a string has unique characters.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>

        public static bool CheckUnique(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            foreach(char chr in str)
            {
                if(dict.ContainsKey(chr))
                {
                    return false;     
                    
                }
                else
                {
                    dict.Add(chr,1);
                } 

            }
            return true;

        }


        /// <summary>
        /// checks if a number is palindromic.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool checkPalindromic(int num)
        {
            string StringNum = num.ToString();
            string reversedString = "";
            for(int i = 0; i < StringNum.Length; i++)
            {
                reversedString += StringNum[StringNum.Length-1-i];
            }
            if(reversedString.Equals(StringNum))
            {
                return true;
            }
            
            return false;
        }

        
        
       
    }
}
