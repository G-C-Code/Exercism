using System;
using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        StringBuilder sb = new();
        
        if (number % 3 == 0 && number % 5 == 0 && number % 7 == 0)
            sb.Append("PlingPlangPlong");
        else if (number % 3 == 0 && number % 5 == 0)
            sb.Append("PlingPlang");
        else if (number % 5 == 0 && number % 7 == 0)
            sb.Append("PlangPlong");
        else if (number % 3 == 0 && number % 7 == 0)
            sb.Append("PlingPlong");
        else if (number % 3 == 0)
            sb.Append("Pling");
        else if (number % 5 == 0)
            sb.Append("Plang");
        else if (number % 7 == 0)
            sb.Append("Plong");
        else
            sb.Append(number.ToString());

        return sb.ToString();
    }
}
