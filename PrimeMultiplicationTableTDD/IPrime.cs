using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTableTDD
{
    public interface IPrime
    {
        bool IsGreaterThanOne(int num1);
        int GenerateNthPrime(int request );
        List<int> GeneratePrimes(int nthPrime);
    }
}
