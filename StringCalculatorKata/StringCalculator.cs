using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public object Add(string input)
        {
            if (String.IsNullOrEmpty(input)) return 0;

            var numbers = input.Split(',')
                .Select(s => int.Parse(s));

            var result = numbers.Sum();

            return result;
        }
    }
}
