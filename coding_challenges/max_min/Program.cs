using System;

namespace max_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {67,8,0,9};
            System.Console.WriteLine(findMax(array));
        }

        static int findMax(int[] array)
        {
            int max = 0;
            foreach(int num in array)
            {
                if(num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
