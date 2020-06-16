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
            int num = number;
            while(num != 1)
            {
                if(num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num = (num*3) + 1;

                }Console.WriteLine(num);
            }

           
        }
    }
}
