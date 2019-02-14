using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem3
    {
        public static void Solve()
        {
            var n = 600851475143;
            var primeFactors = new List<long>();
            if (n < 2) throw new Exception("The value must larger than 1");
            var prime = 2;
            while (n >= Math.Pow(prime, 2))
            {
                if (n % prime == 0)
                {
                    n = n / prime;
                    primeFactors.Add(prime);
                }
                else prime++;
            }
            primeFactors.Add(n);
            Console.WriteLine(primeFactors.Max());
        }
    }
}
