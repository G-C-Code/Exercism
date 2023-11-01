using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException();

        int aliqoutSum = 0;

        for (int i = 1; i < number; i++)
            if (number % i == 0)
                aliqoutSum += i;

        if (aliqoutSum == number)
            return Classification.Perfect;
        else if (aliqoutSum > number)
            return Classification.Abundant;
        else
            return Classification.Deficient;
    }
}
