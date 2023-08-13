using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        // Calculate the distance from the origin (0, 0) using the distance formula
        double distance = Math.Sqrt(x * x + y * y);

        if (distance <= 1)
            return 10;
        else if (distance <= 5)
            return 5;
        else if (distance <= 10)
            return 1;
        else
            return 0;
    }
}
