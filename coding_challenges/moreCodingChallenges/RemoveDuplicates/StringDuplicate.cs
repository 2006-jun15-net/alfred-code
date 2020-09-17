using System;

namespace RemoveDuplicates
{
    public class StringDuplicate
    {
        public StringDuplicate()
        {
            
        }

        public string RemoveDuplicateString(string str)
        {
            //create a variable that will store the string
            string modifiedString = "";

            //loop through the string.
            foreach(char ch in str)
            {
                //check if the new string has the character. if the index is -1, this means that the character is not in the string.
                if(modifiedString.IndexOf(ch) == -1)
                {
                    modifiedString += ch;
                }
            }
            return modifiedString;
        }
    }


}
