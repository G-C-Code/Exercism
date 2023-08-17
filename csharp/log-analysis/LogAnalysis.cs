using System;

public static class LogAnalysis 
{
    // Extension method to retrieve the string after a specific substring
    public static string SubstringAfter(this string input, string substring)
    {
        // Find the starting index of the substring
        int startIndex = input.IndexOf(substring);
        
        // If the substring is found
        if (startIndex != -1)
            // Return the substring that starts after the found substring
            return input.Substring(startIndex + substring.Length);
        else
            // Throw an exception if the substring is not found
            throw new ArgumentException("Substring not found.", nameof(substring));
    }

    // Extension method to retrieve the string in between two substrings
    public static string SubstringBetween(this string input, string start, string end)
    {
        // Find the starting index of the start substring
        int startIndex = input.IndexOf(start);
        
        // Find the ending index of the end substring, starting from startIndex to avoid a match within the "start" delimiter
        int endIndex = input.IndexOf(end, startIndex + start.Length);

        // If both start and end substrings are found
        if (startIndex != -1 && endIndex != -1)
            // Return the substring that starts after the start substring and ends before the end substring
            return input.Substring(startIndex + start.Length, endIndex - startIndex - start.Length);
        else
            // Throw an exception if either start or end substring is not found
            throw new ArgumentException("Start and/or end not found.", nameof(input));
    }

    // Extension method to parse message in a log
    public static string Message(this string input)
    {
        // Use SubstringAfter method to extract the message content after "]: "
        return input.SubstringAfter("]: ");
    }

    // Extension method to parse log level in a log
    public static string LogLevel(this string input)
    {
        // Use SubstringBetween method to extract the log level between "[" and "]"
        return input.SubstringBetween("[", "]");
    }
}
