using System;

namespace PrimeCheck
{
    public class IsPrime
    {
        public IsPrime(){}

       

        /// <summary>
        /// checks if a number is a prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        public bool isPrime(int number)
        {
             if( number <= 1)
            {
                return false;
            }
            int Numfactors = 0;
            for(int i = number; i >= 1; i--)
            {
                if(number % i == 0)
                {
                    Numfactors++;
                    
                } 

            }
             if(Numfactors == 2)
                {
                    return true;
                }
            return false;
        }
    }
}
