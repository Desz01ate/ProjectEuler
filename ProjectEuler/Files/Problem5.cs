using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem5 : IProblem
    {
        public object Answer { get; private set; }

        public object Solve()
        {
            var guessValue = 2520;
            var flag = false;
            while (!flag)
            {
                for (var i = 1; i < 21; i++)
                {
                    if (guessValue % i != 0)
                    {
                        flag = false;
                        break;
                    }
                    else flag = true;
                }
                if (flag)
                {
                    Answer = guessValue;
                    return Answer;
                }
                guessValue++;
            }
            throw new Exception("Can not find suitable answer.");
        }
    }
}
