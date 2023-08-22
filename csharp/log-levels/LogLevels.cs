using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int startIndex = logLine.IndexOf(']');
        
        if (startIndex != -1 && startIndex + 3 < logLine.Length)
            return logLine.Substring(startIndex + 2).TrimStart().TrimEnd();
        else
            throw new ArgumentException("Invalid log line format.", nameof(logLine));
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf('[');
        int endIndex = logLine.IndexOf(']');

        if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
        {
            string logLevel = logLine.Substring(startIndex + 1, endIndex - startIndex - 1);
            return logLevel.ToLower();
        }
        else
        {
            throw new ArgumentException("Invalid log line format.", nameof(logLine));
        }
    }
    public static string Reformat(string logLine)
    {
        string logInfo = "";
        string logLevel = "";
        int startIndex = logLine.IndexOf(']');

        if (startIndex != -1 && startIndex + 3 < logLine.Length)
            logInfo = logLine.Substring(startIndex + 2).TrimStart().TrimEnd();
        else
            throw new ArgumentException("Invalid log line format.", nameof(logLine));

        startIndex = logLine.IndexOf('[');
        int endIndex = logLine.IndexOf(']');

        if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            logLevel = logLine.Substring(startIndex + 1, endIndex - startIndex - 1).ToLower();
        else
            throw new ArgumentException("Invalid log line format.", nameof(logLine));

        return logInfo + " " + "(" + logLevel + ")";
    }
}
