using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var nucleotideCount = new Dictionary<char, int>();

        int a = 0;
        int c = 0;
        int g = 0;
        int t = 0;
        
        if (Regex.IsMatch(sequence.ToUpper(), "^[ACGT]+$"))
        {
            foreach (char ch in sequence.ToUpper())
            {
                switch (ch)
                {
                    case 'A':
                        a++;
                        break;
                    case 'C':
                        c++;
                        break;
                    case 'G':
                        g++;
                        break;
                    case 'T':
                        t++;
                        break;
                }

            }
        }
        else if (sequence == string.Empty)
        {
            
        }
        else
        {
            throw new ArgumentException();
        }
        
        nucleotideCount.Add('A', a);
        nucleotideCount.Add('C', c);
        nucleotideCount.Add('G', g);
        nucleotideCount.Add('T', t);

        return nucleotideCount;
    }
}