using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem15 : IProblem
    {
        public object Answer => throw new NotImplementedException();
        const int GRID_SIZE = 100;
        public object Solve()
        {
            var grid = new long[GRID_SIZE + 1, GRID_SIZE + 1];
            //base solution initialize
            for (var i = 0; i < GRID_SIZE; i++)
            {
                grid[i, GRID_SIZE] = 1;
                grid[GRID_SIZE, i] = 1;
            }


            for (var x = GRID_SIZE - 1; x >= 0; x--)
            {
                for (var y = GRID_SIZE - 1; y >= 0; y--)
                {
                    //calculate from each adjacent grid backward to the [0,0].
                    grid[x, y] = grid[x + 1, y] + grid[x, y + 1];
                }
            }

            return grid[0, 0];
        }
        private void VisualizeGrid(long[,] array) //where T : IComparable<T>, IComparable
        {
            for (var y = 0; y < array.GetLength(1); y++)
            {
                for (var x = 0; x < array.GetLength(0); x++)
                {
                    Console.Write("{0,7} | ", FormatNumber(array[x, y]));
                }
                Console.WriteLine();
            }
        }
        private string FormatNumber(long num)
        {
            if (num >= 100000)
                return FormatNumber(num / 1000) + "K";
            if (num >= 10000)
            {
                return (num / 1000D).ToString("0.#") + "K";
            }
            return num.ToString("#,0");
        }
    }
}
