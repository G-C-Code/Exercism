using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if (number < 0)
            throw new ArgumentException();

        int isArmstrongNumber = 0;
        
        string parsed = number.ToString();

        foreach (char c in parsed)
        {
            isArmstrongNumber += (int)Math.Pow(c - '0', parsed.Length);
        }
        
        return number == isArmstrongNumber;
    }
}
