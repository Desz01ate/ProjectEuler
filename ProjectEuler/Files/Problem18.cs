using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem18 : IProblem
    {
        public object Answer => throw new NotImplementedException();

        public object Solve()
        {
            var triangle =
                $@"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            var triangleArray = ParseInput(triangle);
            var allSol = (int)Math.Pow(2, triangleArray.GetLength(0) - 1);
            var maxSum = 0;
            for (var idx = 0; idx <= allSol; idx++)
            {
                var tempSum = triangleArray[0, 0];
                int tempIdx = 0;
                for (var iter = 0; iter < triangleArray.GetLength(0) - 1; iter++)
                {
                    tempIdx += (idx >> iter & 1);
                    tempSum += triangleArray[iter + 1, tempIdx];
                }
                maxSum = Math.Max(maxSum, tempSum);
            }
            return maxSum;
        }
        private int[][] ParseInputToArray(string input)
        {
            var lines = input.Replace("\r", "").Split('\n');
            var array = new int[lines.Length][];
            for (var lineIdx = 0; lineIdx < lines.Length; lineIdx++)
            {
                var elements = lines[lineIdx].Split().Select(x => int.Parse(x));
                array[lineIdx] = elements.ToArray();
            }
            return array;
        }
        private int[,] ParseInput(string input)
        {
            var lines = input.Replace("\r", "").Split('\n');
            var array = new int[lines.Length, lines.Length];
            for (var lineIdx = 0; lineIdx < lines.Length; lineIdx++)
            {
                var elements = lines[lineIdx].Split();
                for (var elementIdx = 0; elementIdx < elements.Length; elementIdx++)
                {
                    array[lineIdx, elementIdx] = int.Parse(elements[elementIdx]);
                }
            }
            return array;
        }
        private void VisualizeArray(int[,] array)
        {
            for (var y = 0; y < array.GetLength(1); y++)
            {
                for (var x = 0; x < array.GetLength(0); x++)
                {
                    Console.Write($@"{array[y, x]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
