using System;

namespace AnagramCheck
{
    public class Anagram
    {
        public Anagram()
        {
            
        }
         public bool CheckAnagram(string s1, string s2)
        {
            //check if the length of the strings is equal
            if(s1.Length != s2.Length)
            {
                return false;
            }

            else if(sortedString(s1).Equals(sortedString(s2)))
            {
                return true;
            }

            return false;
            
        }

        public string sortedString(string s)
        {
            //convert the array into an array of characters
            char[] charArray = s.ToCharArray();
            //using sort method from Array class

            Array.Sort(charArray);

            return String.Join("",charArray);
            

        }
    }
}
