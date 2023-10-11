using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        if (shiftKey < 0 || shiftKey > 26)
            throw new ArgumentOutOfRangeException("Shift key must be between 0 and 26.");

        string result = "";

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char start = char.IsUpper(c) ? 'A' : 'a';
                char shiftedChar = (char)(start + (c - start + shiftKey) % 26);
                result += shiftedChar;
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}
