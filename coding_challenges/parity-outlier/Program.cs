using System;
using System.Collections.Generic;

namespace parity_outlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {160, 3, 1719, 19, 11, 13, -21};
            System.Console.WriteLine(parityCheck(array));

            
        }

        static int parityCheck(int[] array)
        {
            int outlier = 0;
            
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            foreach(int num in array)
            {
                if(num % 2 != 0)
                {
                    odd.Add(num);
                }

                else
                {
                    even.Add(num);
                }
                
            }
            if(odd.Count == 1)
            {
                outlier += odd[0];
            }else if(even.Count == 1)
            {
                outlier += even[0];
            }
           
            return outlier;
            

        }
    }
}
