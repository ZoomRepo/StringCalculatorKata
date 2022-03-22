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
            var cleaned_input = input;
            var number_set = input;
            var delimeters = new List<char> { ',', '\n' };

            if (input.StartsWith("//"))
            {
                number_set = cleaned_input.Split("\n")[1];
                cleaned_input = input.Substring(2, input.Length - 2);
                var delimeter = cleaned_input.Split('\n').First();
                delimeters.Add(Convert.ToChar(delimeter));
            }

            var numbers = number_set.Split(delimeters.ToArray())
                .Select(s => int.Parse(s));

            var result = numbers.Sum();

            return result;
        }
    }
}
