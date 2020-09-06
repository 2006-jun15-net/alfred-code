using System;
using System.Collections.Generic;

namespace digitRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot(123);
        }

        static int DigitalRoot(int num)
        {
            int singleDigit = 0;
            List<int> array = new List<int>();
            while(num != 0)
            {
                int rem = num % 10;
                num /= 10;
                array.Add(rem);

            }
            return 1;
            
            
            

        }
        
    }
}
