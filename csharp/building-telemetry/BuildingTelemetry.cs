using System.Collections.Generic;

public class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int distanceDrivenInMeters = 0;
    private List<string> sponsors = new();
    private int latestSerialNum = 0;

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            batteryPercentage -= 10;
            distanceDrivenInMeters += 2;
        }
    }

    public void SetSponsors(params string[] sponsors) => this.sponsors.AddRange(sponsors);

    public string DisplaySponsor(int sponsorNum) => sponsors[sponsorNum];

    public bool GetTelemetryData(ref int serialNum,
        out int batteryPercentage, out int distanceDrivenInMeters)
    {
        if (latestSerialNum >= serialNum)
        {
            serialNum = latestSerialNum;
            batteryPercentage = -1;
            distanceDrivenInMeters = -1;
            return false;
        }
        else
        {
            latestSerialNum = serialNum;
            batteryPercentage = this.batteryPercentage;
            distanceDrivenInMeters = this.distanceDrivenInMeters;
            return true;
        }
    }

    public static RemoteControlCar Buy() => new RemoteControlCar();
}

public class TelemetryClient
{
    private RemoteControlCar car;

    public TelemetryClient(RemoteControlCar car) => this.car = car;

    public string GetBatteryUsagePerMeter(int serialNum) => !car.GetTelemetryData(ref serialNum,
        out int batteryPercentage, out int distanceDrivenInMeters) || distanceDrivenInMeters == 0
        ? "no data"
        : $"usage-per-meter={(100-batteryPercentage)/distanceDrivenInMeters}";
}
