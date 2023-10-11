using System;

public class WeighingMachine
{
    private int precision;
    private double tareAdjustment;

    public WeighingMachine(int precision)
    {
        this.precision = precision;
        this.TareAdjustment = 5.0;
    }

    public int Precision
    {
        get { return precision; }
    }

    public double Weight
    {
        get { return WeightWithoutTare; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Cannot be negative.");

            WeightWithoutTare = value;
        }
    }

    private double WeightWithoutTare { get; set; }

    public double TareAdjustment
    {
        get { return tareAdjustment; }
        set { tareAdjustment = value; }
    }

    public string DisplayWeight
    {
        get
        {
            double displayWeight = WeightWithoutTare - TareAdjustment;
            string displayWeightString = displayWeight.ToString("F" + precision) + " kg";
            return displayWeightString;
        }
    }
}
