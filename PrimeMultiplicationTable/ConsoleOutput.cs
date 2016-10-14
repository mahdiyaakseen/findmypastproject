using PrimeMultiplicationTableTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTable
{
    class ConsoleOutput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number(greater than 1) of primes required: ");
            string primesRequestedStr = Console.ReadLine();
            int primesRequested = 0;
            int.TryParse(primesRequestedStr,out primesRequested);
            if (primesRequested<1)
            {
                Console.WriteLine("number requested lesser than 1");
                return;
            }
            else
            {
                PrimeGenerator primeGen = new PrimeGenerator();
                List<int> primes = primeGen.GeneratePrimes(primesRequested);
                PrimeMultiplicationTableGenerator PMTableGen = new PrimeMultiplicationTableGenerator();
                List<List<int>> pMTable = PMTableGen.GeneratePrimeMultiplicationTable(primes);
                Console.Write("{0,0}{1,4}", "|", "|");
                foreach (int p in primes)
                {
                    Console.Write("{0,3}{1,1}", p, "|");
                }
                Console.WriteLine();
                for (int i = 0; i < pMTable.Count(); i++)
                {
                    Console.Write("{0,0}{1,3}{2,1}", "|", primes[i], "|");
                    for (int j = 0; j < pMTable.Count(); j++)
                    {
                        Console.Write("{0,3}{1,1}", pMTable[i][j], "|");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }

        }
    }
}
