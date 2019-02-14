using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class PalindromeMaker
    {
        public int left { get; set; }
        public int right { get; set; }
        public int value { get; set; }
    }
    class Problem4
    {
        public static void Solve()
        {
            var dataset = new List<PalindromeMaker>();
            for (var i = 100; i < 999; i++)
            {
                for (var j = 100; j < 999; j++)
                {
                    var product = (i * j).ToString();
                    if (product.Length % 2 == 0)
                    {
                        var palindrom = false;
                        var head = product.Substring(0, product.Length / 2).ToArray();
                        var tail = product.Substring(product.Length / 2, product.Length / 2).Reverse().ToArray();
                        for (var k = 0; k < head.Length; k++)
                        {
                            if (head[k] != tail[k])
                            {
                                palindrom = false;
                                break;
                            }
                            palindrom = true;
                        }
                        if (palindrom)
                        {
                            dataset.Add(new PalindromeMaker()
                            {
                                left = i,
                                right = j,
                                value = int.Parse(product)
                            });
                        }
                    }
                }
            }
            var ordered = dataset.OrderBy(x => x.value).Last();
            Console.WriteLine($@"{ordered.left} x {ordered.right} = {ordered.value}");
            Console.WriteLine("done");
        }
    }
}
