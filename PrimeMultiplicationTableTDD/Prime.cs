using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTableTDD
{
    public class Prime : IPrime 
    {
       
        public bool IsGreaterThanZero(int primeRequest)
        {
            bool result = false;
            
            if (primeRequest>1)
            {
                result= true;
            }
            return result;
        }

        public int GenerateNthPrime(int nthP)
        {
            //throw new NotImplementedException();
            // code credit - stack overflow topic elegant way to generate primes
            double n = (double)nthP;
            double p;
            if (nthP >= 7022)
            {
                p = n * Math.Log(n) + n * (Math.Log(Math.Log(n)) - 0.9385);
            }
            else if (nthP >= 6)
            {
                p = n * Math.Log(n) + n * Math.Log(Math.Log(n));
            }
            else if (nthP > 0)
            {
                p = new int[] { 2, 3, 5, 7, 11 }[nthP - 1];
            }
            else
            {
                p = 0;
            }
            return (int)p;
        }

        public List<int> GeneratePrimes(int request)
        {
            throw new NotImplementedException();
        }

        
    }
}
