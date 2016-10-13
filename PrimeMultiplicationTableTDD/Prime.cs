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
        public List<int> GeneratePrimes(int request)
        {

            throw new NotImplementedException();
        }

        

        public bool IsGreaterThanZero(int primeRequest)
        {
            bool result = false;
            
            if (primeRequest>1)
            {
                result= true;
            }
            return result;
        }



    }
}
