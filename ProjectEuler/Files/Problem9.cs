using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem9 : IProblem
    {
        public object Answer { get; private set; }

        public object Solve()
        {
            var goal = 1000;
            var answer = -1;
            for (var a = 1; a < goal; a++)
            {
                int b;
                for (b = a; b < goal; b++)
                {
                    int c = goal - a - b;
                    if (!(a < b) || !(b < c)) continue;
                    if ((a * a) + (b * b) == (c * c))
                    {
                        answer = a * b * c;
                        break;
                    }
                }
                if (answer != -1) break;
            }
            Answer = answer;
            return Answer;

        }
    }
}
