using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string pattern = "[^a-zA-Z]";
        string modifiedWord = Regex.Replace(word.ToLower(), pattern, String.Empty);
        char[] letters = modifiedWord.ToCharArray();
        
        Array.Sort(letters);

        for (int i = 0; i < letters.Length - 1; i++)
            if (letters[i] == letters[i + 1])
                return false;
        return true;
    }
}