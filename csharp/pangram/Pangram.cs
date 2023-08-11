using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToUpper();
            
        int counter = 0;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        foreach (char letter in alphabet)
            if (!input.Contains(letter))
                return false;
        
        return true;
    }
}