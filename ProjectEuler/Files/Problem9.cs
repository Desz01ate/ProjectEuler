using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem9
    {
        public static void Solve()
        {
            var goal = 1000;
            var answer = -1;
            var a = 0;
            var b = 0;
            var c = 0;
            for (a = 1; a < goal; a++)
            {
                for (b = a; b < goal; b++)
                {
                    c = goal - a - b;
                    if (!(a < b) || !(b < c)) continue;
                    if ((a * a) + (b * b) == (c * c))
                    {
                        answer = a * b * c;
                        break;
                    }
                }
                if (answer != -1) break;
            }
            Console.WriteLine($@"{answer}");
        }
    }
}
