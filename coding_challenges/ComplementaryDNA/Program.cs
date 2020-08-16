using System;
using System.Collections.Generic;

namespace ComplementaryDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {2, 2, 4,2,2 };
            System.Console.WriteLine(findUniq(array));
            
        }

        static int findUniq(int[] array)
        {
            int unique = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[i] != array[j])
                    {
                        unique = array[i];

                    }
                }
            }return unique;
            
        }
    }
}
