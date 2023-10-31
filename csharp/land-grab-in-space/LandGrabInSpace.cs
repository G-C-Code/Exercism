using System;
using System.Collections.Generic;
using System.Linq;

public struct Coord
{
    public ushort X { get; }
    public ushort Y { get; }
    public Coord(ushort x, ushort y) => (X, Y) = (x, y);

    public double DistanceTo(Coord other) =>
        Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
}

public struct Plot : IComparable<Plot>
{
    public Coord Coord1 { get; }
    public Coord Coord2 { get; }
    public Coord Coord3 { get; }
    public Coord Coord4 { get; }

    public Plot(Coord coord1, Coord coord2, Coord coord3, Coord coord4) => (Coord1, Coord2, Coord3, Coord4) = (coord1, coord2, coord3, coord4);

    public double LongestSide()
    {
        double[] sides = new double[]
        {
            Coord1.DistanceTo(Coord2),
            Coord2.DistanceTo(Coord3),
            Coord3.DistanceTo(Coord4),
            Coord4.DistanceTo(Coord1)
        };

        return sides.Max();
    }

    public int CompareTo(Plot other) => LongestSide().CompareTo(other.LongestSide());
}

public class ClaimsHandler
{
    public List<Plot> StakedClaims = new List<Plot>();

    public void StakeClaim(Plot plot) => StakedClaims.Add(plot);

    public bool IsClaimStaked(Plot plot) => StakedClaims.Contains(plot);

    public bool IsLastClaim(Plot plot) =>
        StakedClaims.Count > 0
            ? StakedClaims[^1].Equals(plot)
            : throw new ArgumentOutOfRangeException();

    public Plot GetClaimWithLongestSide()
    {
        StakedClaims.Sort();
        
        if (StakedClaims.Count > 0)
            return StakedClaims[^1];
        else
            throw new ArgumentOutOfRangeException();
    }
}
