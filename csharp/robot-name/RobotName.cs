using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random random = new Random();
    private static readonly HashSet<string> usedNames = new HashSet<string>();

    private string name;

    public string Name
    {
        get
        {
            if (name == null)
            {
                GenerateUniqueName();
            }
            return name;
        }
    }

    public void Reset()
    {
        usedNames.Remove(name);
        name = null;
    }

    private void GenerateUniqueName()
    {
        string newName;
        do
        {
            newName = GenerateRandomName();
        }
        while (!usedNames.Add(newName));

        name = newName;
    }

    private string GenerateRandomName()
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char letter1 = letters[random.Next(letters.Length)];
        char letter2 = letters[random.Next(letters.Length)];
        int number = random.Next(1000);

        return $"{letter1}{letter2}{number:D3}";
    }
}
