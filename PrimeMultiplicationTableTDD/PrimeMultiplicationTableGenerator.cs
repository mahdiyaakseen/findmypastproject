using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTableTDD
{

    //no need for interface as per KISS?
    public class PrimeMultiplicationTableGenerator
    {
        public List<List<int>> GeneratePrimeMultiplicationTable(List<int> primes)
        {
            List<List<int>> primeMultiplicationTable = new List<List<int>>();
            int index = 0;
            foreach (int p in primes)
            {
                primeMultiplicationTable.Add(new List<int>());
                foreach (int j in primes)
                {
                    primeMultiplicationTable[index].Add(p * j);
                }
                index++;
            }
            return primeMultiplicationTable;
        }

        public List<List<int>> GeneratePrimeMultiplicationTable(int primesRequested)
        {
            PrimeGenerator primeGen = new PrimeGenerator();
            int nthPrime = primeGen.GenerateNthPrime(primesRequested);
            List<int> primes = primeGen.GeneratePrimes(nthPrime);
            List<List<int>> primeMultiplicationTable = GeneratePrimeMultiplicationTable(primes);
            return primeMultiplicationTable;
        }
    }
}
