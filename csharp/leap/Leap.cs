using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isLeapYear = true;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    return isLeapYear;

                else
                    return !isLeapYear;
            }
            else
            {
                return isLeapYear;
            }
        }
        else
        {
            return !isLeapYear;
        }
    }
}