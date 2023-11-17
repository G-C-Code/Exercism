using System;
using System.Text;
using System.Collections.Generic;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        StringBuilder sb = new();
        int rle = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1)
            {
                if (input[i] == input[i+1])
                {
                    rle++;
                }
                else
                {
                    if (rle > 1)
                        sb.Append(rle);

                    sb.Append(input[i]);
                    rle = 1;
                }
            }
            else
            {
                if (rle > 1)
                {
                    sb.Append(rle); sb.Append(input[i]);
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
        }

        return sb.ToString();
    }

    public static string Decode(string input)
    {
        StringBuilder repeat = new();
        StringBuilder sb = new();
        int rld = 1;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
                repeat.Append(c);

            else
            {
                if (repeat.Length > 0)
                    Int32.TryParse(repeat.ToString(), out rld);

                for (int i = 0; i < rld; i++)
                    sb.Append(c);

                repeat.Clear();
                rld = 1;
            }
        }

        return sb.ToString();
    }
}
