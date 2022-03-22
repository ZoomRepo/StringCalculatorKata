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
            var cleanedInput = input;
            var numberSet = input;
            var delimeters = new List<char> { ',', '\n' };
            var error_values = "";
            var result = 0;

            if (String.IsNullOrEmpty(input)) return result;

            if (input.StartsWith("//"))
            {
                numberSet = cleanedInput.Split("\n")[1];
                cleanedInput = input.Substring(2, input.Length - 2);
                var delimeter_section = cleanedInput.Split('\n').First();
                if (delimeter_section.Contains("[")) {
                    var delimeter_list = delimeter_section.Split("]");
                    var cleanDelimeterList = delimeter_list.Select(s => s.TrimStart('[').TrimEnd(']')).Where(n => n.Length > 0).ToArray();
                    
                    foreach(var delimeter in cleanDelimeterList) numberSet = numberSet.Replace(delimeter, ",");
                } else
                {
                    delimeters.Add(Convert.ToChar(delimeter_section));
                }
            }

            var numbers = numberSet
                .Split(delimeters.ToArray())
                .Select(s => int.Parse(s)).Where(n => n < 1000);

            foreach(var value in numbers) if (value.ToString().Contains("-")) error_values += (value) + ", ";

            if (error_values.Count() > 0) throw new Exception("Negatives not allowed: " + error_values.ToString().TrimEnd(' ', ','));

            result = numbers.Sum();
            return result;
        }
    }
}
