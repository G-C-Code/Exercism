class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int expectedMinutesInOven = 40;
        return expectedMinutesInOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int x)
    {
        int expectedMinutesInOven = ExpectedMinutesInOven();
        int remainingMinutesInOven = expectedMinutesInOven - x;
        return remainingMinutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int x)
    {
        int preparationTimeInMinutes = x * 2;
        return preparationTimeInMinutes;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int x, int y)
    {
        int elapsedTimeInMinutes = (x * 2) + y;
        return elapsedTimeInMinutes;
    }
}
