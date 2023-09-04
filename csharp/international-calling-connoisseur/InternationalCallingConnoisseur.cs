using System;
using System.Collections.Generic;

public static class DialingCodes
{

    public static Dictionary<int, string> GetEmptyDictionary()
    {
        var existingDictionary = new Dictionary<int, string>();
        return existingDictionary;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var existingDictionary = new Dictionary<int, string>
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };

        return existingDictionary;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var existingDictionary = new Dictionary<int, string>
        {
            {countryCode, countryName}
        };

        return existingDictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);

        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
            return existingDictionary[countryCode];
        else
            return string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);        
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {

        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;

            return existingDictionary;
        }
            
        else
        {
            return existingDictionary;
        }
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        string countryName = "";

        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
            existingDictionary.Remove(countryCode, out countryName);

            return existingDictionary;
        }
        else
        {
            return existingDictionary;
        }
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestCountryName = string.Empty;

        foreach (string countryName in existingDictionary.Values)
            if (countryName != string.Empty)
                if (countryName.Length > longestCountryName.Length)
                    longestCountryName = countryName;

        return longestCountryName;
    }
}