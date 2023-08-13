using System;
using System.Collections.Generic;


public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length > 0)
        {
            List<string> songComponents = new List<string>();

            for (int i = 0; i < subjects.Length - 1; i++)
            {
                songComponents.Add($"For want of a {subjects[i]} the {subjects[i+1]} was lost.");
            }
            songComponents.Add($"And all for the want of a {subjects[0]}.");

            return songComponents.ToArray();
        }
        else
        {
            return Array.Empty<string>();
        }
    }
}