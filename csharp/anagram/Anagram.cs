using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private char[] _sortedChars;
    private string _baseWordUpperCase;

    public Anagram(string baseWord)
    {
        _sortedChars = GetSortedChars(baseWord);
        _baseWordUpperCase = baseWord.ToUpper();
    }

    private char[] GetSortedChars(string word)
    {
        var chars = word.ToLower().ToCharArray();
        Array.Sort(chars);
        return chars;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> anagrams = new();

        foreach (string s in potentialMatches)
            if (s.ToUpper() != _baseWordUpperCase && _sortedChars.SequenceEqual(GetSortedChars(s)))
                anagrams.Add(s);

        return anagrams.ToArray();
    }
}
