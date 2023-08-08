using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeek;
    }

    public int Today()
    {
        int birdsToday = birdsPerDay[birdsPerDay.Length - 1];
        return birdsToday;
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;    
    }

    public bool HasDayWithoutBirds()
    {
        bool hasDayWithoutBirds = false;
        foreach (int bird in birdsPerDay)
            if (bird == 0)
                return hasDayWithoutBirds = true;
        return hasDayWithoutBirds = false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int countForFirstDays = 0;
        for (int i = 0; i <= numberOfDays - 1; i++)
            countForFirstDays += birdsPerDay[i];
        return countForFirstDays;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int bird in birdsPerDay)
            if (bird >= 5)
                busyDays += 1;
        return busyDays;
    }
}
