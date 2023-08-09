using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        
        Array.Reverse(charArray);
        return new string (charArray);
    }
}