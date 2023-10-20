using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string input, string substring)
    {
       return (input != null && input.Length > 0)
            ? input.Substring(input.IndexOf(substring) + substring.Length)
            : input;
    } 

    public static string SubstringBetween(this string input, string start, string end)
    {
        return (input != null && input.Length > 0)
            ? input.Substring(input.IndexOf(start) + start.Length, input.IndexOf(end) - input.IndexOf(start) - start.Length)
            : input;
    }

    public static string Message(this string input) => input.SubstringAfter(": ");

    public static string LogLevel(this string input) => input.SubstringBetween("[", "]");
}
