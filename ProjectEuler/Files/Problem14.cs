using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem14 : IProblem
    {
        public object Answer => throw new NotImplementedException();
        public object Solve()
        {
            var limit = (int)Math.Pow(10, 6);
            var maxCount = long.MinValue;
            var maxValue = long.MinValue;
            for (long iter = 2; iter <= limit; iter++)
            {
                var current = iter;
                var count = 1;
                while (current != 1)
                {
                    current = Performer(current);
                    count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = iter;
                }
            }
            return maxValue;
        }
        private long Performer(long value)
        {
            return value % 2 == 0 ? value / 2 : (3 * value) + 1;
        }
    }
}
