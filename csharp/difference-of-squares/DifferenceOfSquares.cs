using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int j = 0;
        for (int i = 0; i <= max; i++)
            j += i;
        return j * j;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int j = 0;
        for (int i = 0; i <= max; i++)
            j += i * i;
        return j;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return DifferenceOfSquares.CalculateSquareOfSum(max) - DifferenceOfSquares.CalculateSumOfSquares(max);
    }
}