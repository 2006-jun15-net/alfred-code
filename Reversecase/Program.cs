using System;
using System.Text;

namespace Reversecase
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "abcDeFgHi";

            Console.WriteLine(ReverseCase(str));
            
        }

        static string ReverseCase(string str)
        {
            //creating a stringBuilder object
            //StringBuilder strbuilder = new StringBuilder(str);
            string reversedString = " ";
            for(int i = str.Length -1; i >= 0; i--)
            {
                if(Char.IsUpper(str[i]))
                {
              
                    reversedString += Char.ToLower(str[i]);
                }
                else if(Char.IsLower(str[i]))
                {
                  
                    reversedString += Char.ToUpper(str[i]);
                }
               
            }
            return reversedString;
        }
    }
}
