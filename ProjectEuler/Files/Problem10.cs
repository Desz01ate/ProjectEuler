using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem10 : IProblem
    {
        public object Answer { get; private set; }

        private static bool PrimeCheck(long n)
        {
            if (n <= 1 || n == 2 || n % 2 == 0) return false;
            var primeTest = 3;
            while (Math.Pow(primeTest, 2) <= n)
            {
                if (n % primeTest == 0) return false;
                primeTest += 2;
            }
            return true;
        }
        public object Solve()
        {
            var primes = new List<long>();
            primes.Add(2);
            var prime = 1;
            long n = 1;
            var goal = 2000000;
            while (n < goal)
            {
                n += 2;
                if (PrimeCheck(n))
                {
                    primes.Add(n);
                    prime++;
                }
            }
            Answer = primes.Sum();
            return Answer;
        }
    }
}
