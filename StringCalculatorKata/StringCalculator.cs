using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public object Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;
            
            var result = numbers.Split(',')
                .Select(s => int.Parse(s));

            return result.Sum();
        }

    }
}
