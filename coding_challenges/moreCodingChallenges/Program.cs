using System;
using PrimeCheck;

namespace moreCodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = {3,6,9,1,35};
            //System.Console.WriteLine(maximumGap(array));

            IsPrime primeCheck = new IsPrime();

            System.Console.WriteLine(primeCheck.isPrime(-2));

            
            
        }

        static int maximumGap(int[] array)
        {
            //sort the array first using selection sort
            int temp = 0;
            int maxGap =0;
            for(int i = 0; i < array.Length; i++)
            {
                int max = i;
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[max] > array[j])
                    {
                        temp = array[max];
                        array[max] = array[j];
                        array[j] = temp;
                        
                    }
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if(j-i == 1)
                    {
                        int gap = array[j] - array[i];
                        if(gap > maxGap)
                        {
                            maxGap = gap;
                        }
                    }
                }
            }return maxGap;
        }

        
       
    }
}
