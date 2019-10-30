using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem7 : IProblem
    {
        public object Answer { get; private set; }

        private bool PrimeCheck(int n)
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
            var prime = 1;
            var n = 1;
            while (prime < 10001)
            {
                n += 2;
                if (PrimeCheck(n))
                    prime++;
            }
            Answer = n;
            return Answer;
        }
    }
}
