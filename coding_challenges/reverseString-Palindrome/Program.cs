using System;

namespace reverseString_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(reverseString("madam"));
            System.Console.WriteLine(isPalindrome("aa"));
           

        }

        static string reverseString(string str)
        {
            string reversedString = "";
            for(int i = 0; i < str.Length; i++)
            {
                reversedString += str[str.Length-1-i];
            }

            return reversedString;

        }

        static bool isPalindrome(string str)
        {
            string revString = reverseString(str);
            if(str == revString)
            {
                return true;
            }
            
            return false;
        }
        
    }
}
