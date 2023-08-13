using System;
using System.Collections.Generic;


public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        strand = strand.ToUpper();
        char[] nucleotide = strand.ToCharArray();

        List<string> proteinSequence = new List<string>();

        for (int i = 0; i < nucleotide.Length; i += 3)
        {
            if (nucleotide[i] == 'U' && nucleotide[i+1] == 'A' && nucleotide[i+2] == 'A' || nucleotide[i] == 'U' && nucleotide[i+1] == 'A' && nucleotide[i+2] == 'G' || nucleotide[i] == 'U' && nucleotide[i+1] == 'G' && nucleotide[i+2] == 'A')
            {
                break;
            }
            else
            {
                if (nucleotide[i] == 'A' && nucleotide[i+1] == 'U' && nucleotide[i+2] == 'G')
                    proteinSequence.Add("Methionine");
                else if (nucleotide[i] == 'U' && nucleotide[i+1] == 'U' && nucleotide[i+2] == 'U' || nucleotide[i] == 'U' && nucleotide[i+1] == 'U' && nucleotide[i+2] == 'C')
                    proteinSequence.Add("Phenylalanine");
                else if (nucleotide[i] == 'U' && nucleotide[i+1] == 'U' && nucleotide[i+2] == 'A' || nucleotide[i] == 'U' && nucleotide[i+1] == 'U' && nucleotide[i+2] == 'G')
                    proteinSequence.Add("Leucine");
                else if (nucleotide[i] == 'U' && nucleotide[i+1] == 'C' && nucleotide[i+2] == 'U' || nucleotide[i] == 'U' && nucleotide[i+1] == 'C' && nucleotide[i+2] == 'C' || nucleotide[i] == 'U' && nucleotide[i+1] == 'C' && nucleotide[i+2] == 'A' || nucleotide[i] == 'U' && nucleotide[i+1] == 'C' && nucleotide[i+2] == 'G')
                    proteinSequence.Add("Serine");
                else if (nucleotide[i] == 'U' && nucleotide[i+1] == 'A' && nucleotide[i+2] == 'U' || nucleotide[i] == 'U' && nucleotide[i+1] == 'A' && nucleotide[i+2] == 'C')
                    proteinSequence.Add("Tyrosine");
                else if (nucleotide[i] == 'U' && nucleotide[i+1] == 'G' && nucleotide[i+2] == 'U' || nucleotide[i] == 'U' && nucleotide[i+1] == 'G' && nucleotide[i+2] == 'C')
                    proteinSequence.Add("Cysteine");
                else if (nucleotide[i] == 'U' && nucleotide[i+1] == 'G' && nucleotide[i+2] == 'G')
                    proteinSequence.Add("Tryptophan");
            }
        }

        string[] proteins = proteinSequence.ToArray();

        return proteins;
    }
}