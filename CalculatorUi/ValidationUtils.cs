using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorUi;
internal class ValidationUtils
{
    private static readonly Regex _numberSymbolRegex = new Regex(@"^[-.,0-9]+$");

    public static void InputNumberValidation(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return;
            //throw new ArgumentException("Input cannot be empty.");
        }

        if (!_numberSymbolRegex.IsMatch(input))
        {
            throw new ArgumentException("Invalid input. Only numbers, '.', and '-' are allowed.");
        }
    }
}
