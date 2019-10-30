using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem16 : IProblem
    {
        public object Answer => throw new NotImplementedException();

        public object Solve()
        {
            var start = BigInteger.Pow(2, 1000);
            var result = start.ToString().ToArray().Select(x => int.Parse(x.ToString())).Sum();
            return result;
        }
    }
}
