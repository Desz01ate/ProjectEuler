using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem1
    {
        public static void Solve()
        {
            var rules = new[] { 3, 5 };
            var lowerbound = 1;
            var upperbound = 1000;
            var multiplies = Enumerable.Range(lowerbound, upperbound - 1).Where(x =>
            {
                for (var i = 0; i < rules.Length; i++)
                {
                    if (x % rules[i] == 0)
                        return true;
                }
                return false;
            }).Sum();
            Console.WriteLine(multiplies);
        }
    }
}
