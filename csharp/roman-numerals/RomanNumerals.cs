using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        var sb = new StringBuilder();

        var romanNumerals = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        if (value > 1 || value < 4000)
        {
            foreach (var numeral in romanNumerals)
            {
                while (value >= numeral.Key)
                {
                    sb.Append(numeral.Value);
                    value -= numeral.Key;
                }
            }
        }

        return sb.ToString();
    }
}
