using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int colorCode = 0;
        color = color.ToLower();

        if (color == "black")
            return colorCode = 0;
        else if (color == "brown")
            return colorCode = 1;
        else if (color == "red")
            return colorCode = 2;
        else if (color == "orange")
            return colorCode = 3;
        else if (color == "yellow")
            return colorCode = 4;
        else if (color == "green")
            return colorCode = 5;
        else if (color == "blue")
            return colorCode = 6;
        else if (color == "violet")
            return colorCode = 7;
        else if (color == "grey")
            return colorCode = 8;
        else if (color == "white")
            return colorCode = 9;
        else
            return colorCode;
    }

    public static string[] Colors()
    {
        return new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}