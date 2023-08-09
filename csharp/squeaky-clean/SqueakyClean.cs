using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        // Replace ASCII control characters with "CTRL"
        string pattern = @"[\x00-\x1F\x7F]";
        string modifiedIdentifier = Regex.Replace(identifier, pattern, "CTRL");

        // Remove Greek letters, digits, and non-character symbols
        pattern = "[α-ω0-9\\p{Cs}]";
        modifiedIdentifier = Regex.Replace(modifiedIdentifier, pattern, String.Empty);

        // Convert the modified identifier into a character array
        char[] charArray = modifiedIdentifier.ToCharArray();

        // Loop through each character in the array
        for (int i = 0; i < charArray.Length; i++)
        {
            // Replace spaces with underscores
            if (charArray[i] == ' ')
                charArray[i] = '_';

            // Capitalize the character after a hyphen
            if (charArray[i] == '-' && i + 1 < charArray.Length)
            {
                // Convert the next character to uppercase
                charArray[i + 1] = char.ToUpper(charArray[i + 1]);

                // Remove the hyphen character
                charArray = new string(charArray).Remove(i, 1).ToCharArray();
            }
        }

        // Convert the character array back to a string
        string modifiedIdentifierFinal = new string(charArray);

        // Return the final modified identifier
        return modifiedIdentifierFinal;
    }
}
