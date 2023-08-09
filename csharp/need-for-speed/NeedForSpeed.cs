using System;

class RemoteControlCar
{
    private int _distanceDriven = 0;
    private int _batteryRemaining = 100;

    public RemoteControlCar (int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public int Speed { get; set;}
    public int BatteryDrain { get; set;}


    public bool BatteryDrained()
    {
        if (_batteryRemaining >= BatteryDrain)
            return false;
        else
            return true;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (_batteryRemaining >= BatteryDrain)
        {
            _distanceDriven += Speed;
            _batteryRemaining -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    public RaceTrack (int distance)
    {
        Distance = distance;
    }

    public int Distance { get; set; }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        bool tryFinishTrack = true;
        int battery = 100;

        for (int i = car.Speed; i < Distance; i += car.Speed)
        {
            battery -= car.BatteryDrain;
            if (battery <= 0)
                return tryFinishTrack = false;
        }
        return tryFinishTrack;
    }
}
