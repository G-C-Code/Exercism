using System;
using System.Text;
using System.Collections.Generic;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        int RLE = 1;
        StringBuilder sb = new();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1)
            {
                if (input[i] == input[i+1])
                {
                    RLE++;
                }
                else if (input[i] != input[i+1] && RLE != 1)
                {
                    sb.Append(RLE.ToString() + input[i]);
                    RLE = 1;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            else if (i == input.Length - 1)
            {
                if (input[i] == input[i-1])
                {
                    sb.Append(RLE.ToString() + input[i]);
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
        List<int> numbers = new List<int>();
        
        StringBuilder sb = new();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1)
            {   
                if (Int32.TryParse(input[i].ToString(), out int first) && Int32.TryParse(input[i+1].ToString(), out int _))
                {
                    numbers.Add(first);
                }
                else if (Int32.TryParse(input[i].ToString(), out int second))
                {
                    numbers.Add(second);

                    string concatenated = string.Join("", numbers);
                    int RLD = Int32.Parse(concatenated);

                    for (int j = 0; j < RLD; j++)
                        sb.Append(i+1);

                    numbers.Clear();
                }
                else if (!Int32.TryParse(input[i-1].ToString(), out int third))
                {
                    sb.Append(i);
                }
            }
            else if (i == input.Length - 1)
            {
                sb.Append(i);
            }
            
        }

        return sb.ToString();
    }
}
