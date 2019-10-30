using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem20 : IProblem
    {
        public object Answer => throw new NotImplementedException();

        public object Solve()
        {
            var x = 10;
            var fact = Factorial(x);
            var sum = fact.ToString().ToArray().Select(x => int.Parse(x.ToString())).Sum();
            return sum;
        }
        private BigInteger Factorial(BigInteger n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
