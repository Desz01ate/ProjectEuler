using ProjectEuler.Files;
using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var prob = new Problem20();
            var res = prob.Solve();
            return;
            var type = typeof(IProblem);
            var problems = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !(p.IsInterface || p.IsAbstract))
                .Select(x => (IProblem)Activator.CreateInstance(x));
            problems.AsParallel().ForAll(problem =>
            //problems.ToList().ForEach(problem =>
            {
                Console.WriteLine($@"{problem.GetType().Name} : answer : {problem.Solve()}");
            });
            Console.ReadLine();
        }
    }
}
