using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem5
    {
        public static void Solve()
        {
            var guessValue = 2520;
            var answer = -1;
            while (answer == -1)
            {
                var flag = false;
                for (var i = 1; i < 21; i++)
                {
                    if (guessValue % i != 0)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(guessValue);
                    return;
                }
                guessValue++;
            }
        }
    }
}
