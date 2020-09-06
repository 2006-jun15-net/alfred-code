using System;

namespace modifiedStairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            modifiedStaircase();
        
        }

         static void modifiedStaircase()
        {
            Console.WriteLine("Enter the size of the staircase");
            String number = Console.ReadLine();
            int size = Convert.ToInt32(number);
             for(int i = 0; i <= size; i++)
            {
                for(int j = 0; j <= size; j++)
                {
                    if((i+j) > size)
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }  
    }
}
