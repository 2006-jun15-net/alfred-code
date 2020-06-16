using System;

namespace staicase
{
    class Program
    {
        static void Main(string[] args)
        {
            staircase();
           
            
        }

        static void staircase()
        {
             for(int i = 0; i <= 8; i++)
            {
                for(int j = 0; j <= 8; j++)
                {
                    if((i+j) > 8)
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
