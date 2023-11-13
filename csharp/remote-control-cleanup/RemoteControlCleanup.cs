public class RemoteControlCar
{
    private enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }

    private struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }
        public Speed(decimal amount, SpeedUnits speedUnits) => (Amount, SpeedUnits) = (amount, speedUnits);
        public override string ToString() =>
            SpeedUnits == SpeedUnits.CentimetersPerSecond
                ? $"{Amount} centimeters per second"
                : $"{Amount} meters per second";
    }

    public interface ITelemetry
    {
        void Calibrate();
        bool SelfTest();
        void ShowSponsor(string sponsorName);
        void SetSpeed(decimal amount, string units);
    }

    private class TelemetryObj : ITelemetry
    {
        private RemoteControlCar thisCar;
        public TelemetryObj(RemoteControlCar car) => thisCar = car;
        public void Calibrate() {}
        public bool SelfTest() => true;
        public void ShowSponsor(string sponsorName) => thisCar.SetSponsor(sponsorName);
        public void SetSpeed(decimal amount, string unitsString) =>
            thisCar.SetSpeed(new Speed(amount, unitsString == "cps"
            ? SpeedUnits.CentimetersPerSecond
            : SpeedUnits.MetersPerSecond));
    }

    public ITelemetry Telemetry { get; }
    public string CurrentSponsor { get; private set; }
    private Speed currentSpeed;
    public RemoteControlCar() => Telemetry = new TelemetryObj(this);
    public string GetSpeed() => currentSpeed.ToString();
    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;
    private void SetSpeed(Speed speed) => currentSpeed = speed;
}
