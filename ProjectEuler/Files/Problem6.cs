using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem6
    {
        public static void Solve()
        {
            var ordinaryNumber = Enumerable.Range(1, 100);
            var firstSquares = ordinaryNumber.Select(x => Math.Pow(x, 2)).Sum();
            var secondSquares = Math.Pow(ordinaryNumber.Sum(), 2);
            var answer = secondSquares - firstSquares;
            Console.WriteLine(answer);
        }
    }
}
