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
            int k = nthPrime / 2;
            BitArray bits = new BitArray(k + 1, true);

            /* SET ALL TO PRIME STATUS */
            bits.SetAll(true);

            /* SEIVE */
            int maxVal = 0;
            int denominator = 0;
            for (int i = 1; i < k; i++)
            {
                denominator = (i << 1) + 1;
                maxVal = (k - i) / denominator;
                for (int j = i; j <= maxVal; j++)
                {
                    bits[i + j * denominator] = false;
                }
            }
            int dummy = 0;
            for (int i = 1; i < k; i++)
            {
                if (bits[i])
                {
                    totalCount++;
                    //dummy = (i << 1) + 1; // dummy contains prime number.The code is here not ignore the prime number calcuation part.
                    result.Add((i << 1) + 1);
                }
            }
            //return (totalCount + 1); // 2 will be missed in Sieve Of Sundaram
            return result;
        }

        
    }
}
