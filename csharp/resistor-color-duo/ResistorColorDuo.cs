using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string value = "";

        for (int i = 0; i < 2; i++)
        {
            if (colors[i] == "black")
                value += "0";
            else if (colors[i] == "brown")
                value += "1";
            else if (colors[i] == "red")
                value += "2";
            else if (colors[i] == "orange")
                value += "3";
            else if (colors[i] == "yellow")
                value += "4";
            else if (colors[i] == "green")
                value += "5";
            else if (colors[i] == "blue")
                value += "6";
            else if (colors[i] == "violet")
                value += "7";
            else if (colors[i] == "grey")
                value += "8";
            else if (colors[i] == "white")
                value += "9";
            else
                value += "";
        }

        return Int32.Parse(value);
    }
}