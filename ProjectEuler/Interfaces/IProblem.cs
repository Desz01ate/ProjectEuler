using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Interfaces
{
    interface IProblem
    {
        object Answer { get; }
        object Solve();
    }
}
