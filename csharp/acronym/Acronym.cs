using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronym = "";
        
        // Define a regex pattern that matches characters that are not letters, hyphens, or spaces
        string pattern = "[^a-zA-Z -]";

        // Apply the regex pattern to the input phrase, remove leading/trailing spaces, and create a char array
        char[] modifiedArray = Regex.Replace(phrase.Trim(), pattern, String.Empty).ToCharArray();
        
        // Check if the modifiedArray has at least one character
        if (modifiedArray.Length > 0)
        {
            // Add the first character of the modifiedArray to the acronym
            acronym += modifiedArray[0];

            // Iterate through the modifiedArray starting from the second character
            for (int i = 1; i < modifiedArray.Length; i++)
            {
                // Check if the current character is a space or a hyphen
                if (modifiedArray[i] == ' ' || modifiedArray[i] == '-')
                {
                    // Check if the next character exists and is a letter
                    if (i + 1 < modifiedArray.Length && char.IsLetter(modifiedArray[i + 1]))
                    {
                        // Add the next letter character to the acronym
                        acronym += modifiedArray[i + 1];
                    }
                }
            }
        }

        return acronym.ToUpper();
    }
}
