using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate = 0;

        if (speed == 0)
            return successRate = 0;
        else if (speed <= 4)
            return successRate = 1;
        else if (speed <= 8)
            return successRate = 0.9;
        else if (speed == 9)
            return successRate = 0.8;
        else if (speed == 10)
            return successRate = 0.77;
        else
            return successRate = 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return AssemblyLine.SuccessRate(speed) * speed * 221;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double workingCarsPerMinute = AssemblyLine.SuccessRate(speed) * 221 * speed / 60;
        int workingCarsPerMinuteTruncated = (int)workingCarsPerMinute;
        
        return workingCarsPerMinuteTruncated;
    }
}
