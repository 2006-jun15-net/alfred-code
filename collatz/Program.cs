using System;

namespace collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            String n = Console.ReadLine();
            int number = Convert.ToInt32(n);
            while(number != 1)
            {
                if(number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = (number*3) + 1;

                }Console.WriteLine(number);
            }

           
        }
    }
}
