using System;
using System.Collections.Generic;

namespace coding_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,9,10,45};
            ReverseArray(array);
            foreach(int item in ReverseArray(array))
            {
                System.Console.WriteLine(item);
            }
            
        }

        static int[] ReverseArray(int[] array)
        {
        
            int[] reversedArray = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length-1-i];
                
            }

            return reversedArray;
            
            

        }


    }
}
