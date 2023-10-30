using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class HighScores
{
    public List<int> HS { get; set; }
    public List<int> SortedHS { get; set; }

    public HighScores(List<int> list)
    {
        HS = new List<int>(list);
        SortedHS = new List<int>(HS);
    }

    public List<int> Scores() => HS;

    public int Latest() => HS.Count > 0 ? HS[HS.Count - 1] : throw new ArgumentOutOfRangeException();

    public int PersonalBest()
    {
        if (SortedHS.Count > 0)
        {
            SortedHS.Sort();
            return SortedHS[SortedHS.Count - 1];
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public List<int> PersonalTopThree()
    {
        if (SortedHS.Count > 2)
        {
            SortedHS.Sort();
            return new List<int> { SortedHS[SortedHS.Count - 1], SortedHS[SortedHS.Count - 2], SortedHS[SortedHS.Count - 3] } ;
        }
        else if (SortedHS.Count == 2)
        {
            SortedHS.Sort();
            return new List<int> { SortedHS[1], SortedHS[0] } ;
        }
        else if (SortedHS.Count == 1)
        {
            SortedHS.Sort();
            return new List<int> { SortedHS[0] } ;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}