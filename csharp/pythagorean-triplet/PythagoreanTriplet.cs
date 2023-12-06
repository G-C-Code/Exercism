using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int a, int b, int c)> pythagoreanTriplet = new List<(int a, int b, int c)>();
        
        for (int a = 1; a < sum / 3; a++)
        {
            for (int b = a; b < sum / 2; b++)
            {
                int c = sum - a - b;

                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    pythagoreanTriplet.Add((a, b, c));
                }
            }
        }
        
        return pythagoreanTriplet;
    }
}