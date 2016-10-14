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

        public int GenerateNthPrime(int request)
        {
            //throw new NotImplementedException();
            double n = (double)request;
            double p;
            if (request >= 7022)
            {
                p = n * Math.Log(n) + n * (Math.Log(Math.Log(n)) - 0.9385);
            }
            else if (request >= 6)
            {
                p = n * Math.Log(n) + n * Math.Log(Math.Log(n));
            }
            else if (request > 0)
            {
                p = new int[] { 2, 3, 5, 7, 11 }[request - 1];
            }
            else
            {
                p = 0;
            }
            return (int)p;
        }

        public List<int> GeneratePrimes(int nthPrime)
        {
            //throw new NotImplementedException();
            List<int> result = new List<int>();

            int totalCount = 0;
            int m = nthPrime / 2; // as even numbers will be removed by Sieve of Sundaram,
            BitArray bits = new BitArray(m + 1, true);
            
            // implementing seive of sundaram
            int maxVal = 0;
            int denominator = 0;
            //getting rid of even numbers
            for (int i = 1;i < m; i++)
            {
                denominator = (i << 1) + 1; // bitwise operation multiply by 2 and increment 1, 2i+1
                maxVal = (m - i) / denominator; // max value becomes nthPrime/2 
                //no need to loop j from 0 to m
                for (int j = i; j <= maxVal; j++) //j<(m-1)/(2i+1) from inequality i+j+2ij<m
                {
                    bits[i + j * denominator] = false; //i+j+2ij set as false
                }
            }
            // as SOS gives only odd primes (2i+1)(2j+1) , we manually add the only even prime number i.e., 2
            result.Add(2);
            // for each k remaining in bits (2k+1) is prime
            for (int k = 1; k < m; k++)
            {
                if (bits[k])
                {
                    totalCount++;
                    result.Add((k << 1) + 1);
                }
            }
            return result;
        }

        
    }
}
