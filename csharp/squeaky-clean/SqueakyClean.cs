using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string pattern = @"[\x00-\x1F\x7F]";
        string modifiedIdentifier = Regex.Replace(identifier, pattern, "CTRL");
        char[] charArray = modifiedIdentifier.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] == ' ')
                charArray[i] = '_';

            if (charArray[i] == '-' && i + 1 < charArray.Length)
            {
                charArray[i + 1] = char.ToUpper(charArray[i + 1]);
            }
        }

        string modifiedIdentifierFinal = new(charArray);
        return modifiedIdentifierFinal;
    }
}