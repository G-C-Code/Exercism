using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        // Trim leading and trailing whitespace from the statement
        statement = statement.Trim();

        // Check if the statement consists only of whitespace or is empty
        if (statement.All(char.IsWhiteSpace) || statement == string.Empty)
            return "Fine. Be that way!";
        // Check if the statement is in all uppercase and ends with a question mark
        else if (!statement.Any(char.IsLower) && statement.Any(char.IsUpper) && statement.EndsWith("?"))
            return "Calm down, I know what I'm doing!";
        // Check if the statement is in all uppercase
        else if (!statement.Any(char.IsLower) && statement.Any(char.IsUpper))
            return "Whoa, chill out!";
        // Check if the statement ends with a question mark
        else if (statement.EndsWith("?"))
            return "Sure.";
        // Default response for all other cases
        else
            return "Whatever.";
    }
}
