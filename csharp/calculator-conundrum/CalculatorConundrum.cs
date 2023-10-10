using System;
using System.Linq;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if (operation != null)
        {
            switch (operation)
            {
                case "+":
                    return $"{operand1} + {operand2} = {operand1 + operand2}";
                case "*":
                    return $"{operand1} * {operand2} = {operand1 * operand2}";
                case "/":
                    if (operand2 != 0)
                        return $"{operand1} / {operand2} = {operand1 / operand2}";
                    else
                        return "Division by zero is not allowed.";
                case "":
                    throw new ArgumentException();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        else
            throw new ArgumentNullException();
    }
}
