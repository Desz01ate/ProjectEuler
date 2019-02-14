using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Files
{
    static class Problem2
    {
        public static void Solve()
        {
            long f1 = 1;
            long f2 = 1;
            long result = 0;
            long sum = 0;

            while (result < 4000000)
            {
                if (result % 2 == 0) sum += result;
                result = f1 + f2;
                f2 = f1;
                f1 = result;
            }
            //long sum = even.Sum();
            Console.WriteLine(sum);
        }
    }
}
