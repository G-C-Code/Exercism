using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;
        
        if (firstStrand.Length == secondStrand.Length)
        {
            for (int i = 0; i < firstStrand.Length; i++)
                if (firstStrand[i] != secondStrand[i])
                    hammingDistance += 1;
        }
        else
        {
            throw new ArgumentException();
        }
        
        return hammingDistance;
    }
}