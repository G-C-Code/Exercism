using System;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        StringBuilder sb = new();

        foreach(char c in nucleotide)
        {
            char rna = c switch
            {
                'G' => 'C',
                'C' => 'G',
                'T' => 'A',
                'A' => 'U',
                _ => throw new ArgumentException($"Invalid nucleotide: {c}")
            };
            sb.Append(rna);
        }

        return sb.ToString();
    }
}
