using System;

namespace sortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {45, 1,7,0,8,-3};
            int temp;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach(int item in array)
            {
                System.Console.WriteLine(item);
            }
            
            
            
        }

        
    }
}
