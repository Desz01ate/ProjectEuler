using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem12 : IProblem
    {
        public object Answer => throw new NotImplementedException();

        public object Solve()
        {
            var triangle = 0;
            for (var i = 1; ; i++)
            {
                triangle += i;
                var count = 0;
                var end = Math.Sqrt(triangle);
                for (var x = 1; x < end; x++)
                {
                    if (triangle % x == 0)
                        count += 2;
                }
                if ((end * end == triangle) && count > 500)
                    return triangle;
            }
        }
    }
}
