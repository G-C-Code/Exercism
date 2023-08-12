using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        int i = startBottles;
        int j = takeDown;
        string song = "";

        for (i = startBottles; i > startBottles - takeDown; i--)
        {
            if (i > 2)
            {
                string first = $"{i} bottles of beer on the wall, {i} bottles of beer.";
                string second = $"Take one down and pass it around, {i-1} bottles of beer on the wall.";

                song += first + "\n";
                if (j > 1)
                {
                    song += second + "\n\n";
                    j--;
                }
                else
                {
                    song += second;
                }
            }
            else if (i == 2)
            {
                string first = $"{i} bottles of beer on the wall, {i} bottles of beer.";
                string second = $"Take one down and pass it around, {i-1} bottle of beer on the wall.";

                song += first + "\n";
                if (j > 1)
                {
                    song += second + "\n\n";
                    j--;
                }
                else
                {
                    song += second;
                }
            }
            else if (i == 1)
            {
                string first = $"{i} bottle of beer on the wall, {i} bottle of beer.";
                string second = "Take it down and pass it around, no more bottles of beer on the wall.";

                song += first + "\n";
                if (j > 1)
                {
                    song += second + "\n\n";
                    j--;
                }
                else
                {
                    song += second;
                }
            }
            else if (i == 0)
            {
                string first = "No more bottles of beer on the wall, no more bottles of beer.";
                string second = "Go to the store and buy some more, 99 bottles of beer on the wall.";

                song += first + "\n";
                song += second;
            }
        }

        return song;
    }
}