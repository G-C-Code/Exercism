using System;
using System.Linq;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newFormat = new();

        foreach (string[] oldArray in old.Values)
        {
            foreach(string s in oldArray)
            {
                switch (s)
                {
                    case "A":
                    case "E":
                    case "I":
                    case "O":
                    case "U":
                    case "L":
                    case "N":
                    case "R":
                    case "S":
                    case "T":
                        newFormat.Add(s.ToLower(), 1);
                        break;
                    case "D":
                    case "G":
                        newFormat.Add(s.ToLower(), 2);
                        break;
                    case "B":
                    case "C":
                    case "M":
                    case "P":
                        newFormat.Add(s.ToLower(), 3);
                        break;
                    case "F":
                    case "H":
                    case "V":
                    case "W":
                    case "Y":
                        newFormat.Add(s.ToLower(), 4);
                        break;
                    case "K":
                        newFormat.Add(s.ToLower(), 5);
                        break;
                    case "J":
                    case "X":
                        newFormat.Add(s.ToLower(), 8);
                        break;
                    case "Q":
                    case "Z":
                        newFormat.Add(s.ToLower(), 10);
                        break;
                    default:
                    break;
                }
            }
        }

        return newFormat;
    }
}