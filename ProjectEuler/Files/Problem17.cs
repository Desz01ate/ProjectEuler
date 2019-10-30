using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Files
{
    class Problem17 : IProblem
    {
        public object Answer => throw new NotImplementedException();
        private static string[] ONES = {
        "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
        "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        private static string[] TENS = {
        "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
        public object Solve()
        {
            var count = 0;
            for (var i = 1; i <= 1000; i++)
            {
                var word = ConvertToEnglish(i);
                count += word.Length;
            }
            return count;
        }
        private string ConvertToEnglish(int n)
        {
            if (0 <= n && n < 20)
                return ONES[n];
            else if (20 <= n && n < 100)
                return TENS[n / 10] + (n % 10 != 0 ? ONES[n % 10] : "");
            else if (100 <= n && n < 1000)
                return ONES[n / 100] + "hundred" + (n % 100 != 0 ? "and" + ConvertToEnglish(n % 100) : "");
            else if (1000 <= n && n < 1000000)
                return ConvertToEnglish(n / 1000) + "thousand" + (n % 1000 != 0 ? ConvertToEnglish(n % 1000) : "");
            else
                throw new NotSupportedException();
        }
    }
}
