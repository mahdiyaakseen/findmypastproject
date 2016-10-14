using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTableTDD
{

    //no need for interface as per KISS?
    public class PrimeMultiplicationTable
    {
        public List<List<int>> GeneratePrimeMultiplicationTable(List<int> primes)
        {
            List<List<int>> primeMultiplicationTable = new List<List<int>>();
            // for the ease of display on console , add the primes as first list on matrix
            primeMultiplicationTable.Add(primes);
            int index = 1;
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
    }
}
