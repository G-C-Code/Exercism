using System;

class RemoteControlCar
{
    private int distanceDriven = 0;
    private int batteryRemaining = 100;

    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (batteryRemaining <= 0)
        {
            return "Battery empty";
        }
        return $"Battery at {batteryRemaining}%";
    }

    public void Drive()
    {
        if (batteryRemaining > 0)
        {
            distanceDriven += 20;
            batteryRemaining -= 1;
        }
    }
}
