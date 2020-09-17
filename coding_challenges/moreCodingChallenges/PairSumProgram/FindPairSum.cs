using System;
using System.Collections.Generic;

namespace PairSumProgram
{
    public class FindPairSum
    {

        public FindPairSum()
        {
            
        }

        

        public int CountPairSum(int[] array, int k)
        {
            //store elements in a hash set
            HashSet<string> set = new HashSet<string>();
            if(array.Length == 0)
            {
                throw new Exception("The array is empty");
            }
            
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] + array[j] == k)
                    {
                        
                        string tuple = $"({array[i]},{array[j]})";
                        
                        set.Add(tuple);

                    }
                }
            }
            return set.Count;
            
        }
    }
}
