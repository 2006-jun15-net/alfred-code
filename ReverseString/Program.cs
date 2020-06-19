using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            String s = Console.ReadLine();
            String reverseString = " ";
    
            for(int i = s.Length-1; i >= 0; i-- )
            {
                reverseString += s[i];

            }
            Console.WriteLine(reverseString);
        }
    }
}
