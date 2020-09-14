using System;
using System.Linq;

namespace OccurenceArray
{
    public class Occurence
    {
        public Occurence(){}

        public int FindFrequency(int[] array, int targetNumber)
        {
            
            int freq = array
                       .Where(num => num == targetNumber).Count();
            return freq;      
            
        }
        
    }
}
