using System;
using System.Collections.Generic;

public class Robot
{
    public static HashSet<string> uniqueRobotNames { get; set; } = new HashSet<string>();

    private string generatedName;

    public string Name
    {
        get
        {
            if (string.IsNullOrEmpty(generatedName))
            {
                GenerateName();
            }
            return generatedName;
        }
    }

    public void Reset()
    {
        uniqueRobotNames.Remove(generatedName);
        GenerateName();
    }

    private void GenerateName()
    {
        Random random = new Random();
        string name = "";

        int letterOne = random.Next(0, 26);
        int letterTwo = random.Next(0, 26);
        int numberOne = random.Next(0, 10);
        int numberTWo = random.Next(0, 10);
        int numberThree = random.Next(0, 10);

        if (letterOne == 0)
            name += "A";
        if (letterOne == 1)
            name += "B";
        if (letterOne == 2)
            name += "C";
        if (letterOne == 3)
            name += "D";
        if (letterOne == 4)
            name += "E";
        if (letterOne == 5)
            name += "F";
        if (letterOne == 6)
            name += "G";
        if (letterOne == 7)
            name += "H";
        if (letterOne == 8)
            name += "I";
        if (letterOne == 9)
            name += "J";
        if (letterOne == 10)
            name += "K";
        if (letterOne == 11)
            name += "L";
        if (letterOne == 12)
            name += "M";
        if (letterOne == 13)
            name += "N";
        if (letterOne == 14)
            name += "O";
        if (letterOne == 15)
            name += "P";
        if (letterOne == 16)
            name += "Q";
        if (letterOne == 17)
            name += "R";
        if (letterOne == 18)
            name += "S";
        if (letterOne == 19)
            name += "T";
        if (letterOne == 20)
            name += "U";
        if (letterOne == 21)
            name += "V";
        if (letterOne == 22)
            name += "W";
        if (letterOne == 23)
            name += "X";
        if (letterOne == 24)
            name += "Y";
        if (letterOne == 25)
            name += "Z";

        if (letterTwo == 0)
            name += "A";
        if (letterTwo == 1)
            name += "B";
        if (letterTwo == 2)
            name += "C";
        if (letterTwo == 3)
            name += "D";
        if (letterTwo == 4)
            name += "E";
        if (letterTwo == 5)
            name += "F";
        if (letterTwo == 6)
            name += "G";
        if (letterTwo == 7)
            name += "H";
        if (letterTwo == 8)
            name += "I";
        if (letterTwo == 9)
            name += "J";
        if (letterTwo == 10)
            name += "K";
        if (letterTwo == 11)
            name += "L";
        if (letterTwo == 12)
            name += "M";
        if (letterTwo == 13)
            name += "N";
        if (letterTwo == 14)
            name += "O";
        if (letterTwo == 15)
            name += "P";
        if (letterTwo == 16)
            name += "Q";
        if (letterTwo == 17)
            name += "R";
        if (letterTwo == 18)
            name += "S";
        if (letterTwo == 19)
            name += "T";
        if (letterTwo == 20)
            name += "U";
        if (letterTwo == 21)
            name += "V";
        if (letterTwo == 22)
            name += "W";
        if (letterTwo == 23)
            name += "X";
        if (letterTwo == 24)
            name += "Y";
        if (letterTwo == 25)
            name += "Z";

        name += numberOne + numberTWo + numberThree;

        if (!uniqueRobotNames.Add(name))
        {
            generatedName = name;
        }
    }
}