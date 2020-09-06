using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(String[] args)
        {
            // WorkingWithStrings();
             var fibonacciNumbers = new List<int> {1,1};
            while(true)
            {

                var prev = fibonacciNumbers[fibonacciNumbers.Count -1];
                var prev2 = fibonacciNumbers[fibonacciNumbers.Count -2];

                fibonacciNumbers.Add(prev+prev2);
                if(fibonacciNumbers.Count == 20)
                {
                    break;
                }

            }
           
            //printing the values
            foreach(var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
            
        }
        static void WorkingWithStrings()
        {

            var names = new List<string> {"Alfred", "Ana", "Felipe"};

            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            // The number of people in the list
            Console.WriteLine($"There are {names.Count} people");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }


            
        }

        
    }
}
