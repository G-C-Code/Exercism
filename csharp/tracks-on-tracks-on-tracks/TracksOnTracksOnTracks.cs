using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> LanguageList { get; set; } = new List<string>
    {
        "C#",
        "Clojure",
        "Elm"
    };

    public static List<string> NewList()
    {
        List<string> newList = new List<string>();
        return newList;
    }

    public static List<string> GetExistingLanguages()
    {
        return LanguageList;
    }

    public static List<string> AddLanguage(List<string> LanguageList, string language)
    {
        LanguageList.Add(language);
        return LanguageList;
    }

    public static int CountLanguages(List<string> LanguageList)
    {
        return LanguageList.Count;
    }

    public static bool HasLanguage(List<string> LanguageList, string language)
    {
        foreach (string languages in LanguageList)
            if (languages == language)
                return true;
                
        return false;
    }

    public static List<string> ReverseList(List<string> LanguageList)
    {
        LanguageList.Reverse();
        return LanguageList;
    }

    public static bool IsExciting(List<string> LanguageList)
    {
        if (LanguageList.Count != 0)
            if (LanguageList[0].Contains("C#") || (LanguageList[1].Contains("C#") && (LanguageList.Count == 2 || LanguageList.Count == 3)))
                return true;
                
        return false;
    }

    public static List<string> RemoveLanguage(List<string> LanguageList, string language)
    {
        LanguageList.Remove(language);
        return LanguageList;
    }

    public static bool IsUnique(List<string> LanguageList)
     {
        HashSet<string> seenLanguages = new HashSet<string>();

        foreach (var language in LanguageList)
            if (!seenLanguages.Add(language))
                return false;
    
        return true;
    }
}