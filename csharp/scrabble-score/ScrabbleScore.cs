using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        char[] letters = input.ToUpper().ToCharArray();

        int score = 0;
        
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == 'A' || letters[i] == 'O' || letters[i] == 'U' || letters[i] == 'L' || letters[i] == 'E' || letters[i] == 'I' || letters[i] == 'T' || letters[i] == 'N' || letters[i] == 'R' || letters[i] == 'S')
                score += 1;
            else if (letters[i] == 'D' || letters[i] == 'G')
                score += 2;
            else if (letters[i] == 'B' || letters[i] == 'C' || letters[i] == 'M' || letters[i] == 'P')
                score += 3;
            else if (letters[i] == 'F' || letters[i] == 'H' || letters[i] == 'V' || letters[i] == 'W' || letters[i] == 'Y')
                score += 4;
            else if (letters[i] == 'K')
                score += 5;
            else if (letters[i] == 'J' || letters[i] == 'X')
                score += 8;
            else if (letters[i] == 'Q' || letters[i] == 'Z')
                score += 10;
        }
        return score;
    }
}