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
            var cleaned_input = input;
            var number_set = input;
            var delimeters = new List<char> { ',', '\n' };
            var error_values = "";
            var result = 0;

            if (String.IsNullOrEmpty(input)) return result;

            if (input.StartsWith("//"))
            {
                number_set = cleaned_input.Split("\n")[1];
                cleaned_input = input.Substring(2, input.Length - 2);
                var delimeter = cleaned_input.Split('\n').First();
                delimeters.Add(Convert.ToChar(delimeter));
            }

            var numbers = number_set
                .Split(delimeters.ToArray())
                .Select(s => int.Parse(s)).Where(n => n < 1000);

            foreach(var value in numbers) if (value.ToString().Contains("-")) error_values += (value) + ", ";

            if (error_values.Count() > 0) return "Negatives not allowed: " + error_values.ToString().TrimEnd(' ', ',');

            result = numbers.Sum();
            return result;
        }
    }
}
