using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem19 : IProblem
    {
        public object Answer => throw new NotImplementedException();

        public object Solve()
        {
            int count = 0;
            for (var year = 1901; year <= 2000; year++)
            {
                for (var month = 1; month <= 12; month++)
                {
                    //much of a hack, very no-brainer way...
                    if (new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Sunday)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public object AlternativeSolve()
        {
            int count = 0;
            for (var year = 1901; year <= 2000; year++)
            {
                for (var month = 1; month <= 12; month++)
                {
                    if (ZellerCongruence(1, month, year) == DayOfWeek.Sunday)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /*
         Zeller’s congruence is an algorithm devised by Christian Zeller to calculate the day of the week for any Julian or Gregorian calendar date. 
         It can be considered to be based on the conversion between Julian day and the calendar date.
         It is an algorithm to find the day of the week for any date.
        */
        private DayOfWeek ZellerCongruence(int day, int month, int year)
        {
            if ((month < 1 || 12 < month) || (day < 1 || 31 < day))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (month == 1)
            {
                month = 13;
                year--;
            }
            if (month == 2)
            {
                month = 14;
                year--;
            }

            var q = day;
            var m = month;
            var k = year % 100;
            var j = year / 100;
            var h = (q + (13 * (m + 1) / 5) + k + (k / 4) + (j / 4) - (2 * j)) % 7;

            var result = (DayOfWeek)h;
            return result;
        }
    }
}
