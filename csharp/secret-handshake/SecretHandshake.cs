using System;
using System.Collections.Generic;


public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        string binary = Convert.ToString(commandValue, 2);
        char[] numbers = binary.ToCharArray();

        List<string> secretHandshake = new List<string>();

        if (numbers.Length == 5 && numbers[0] == '1')
        {
            if (numbers[1] == '1')
                secretHandshake.Add("jump");
            if (numbers[2] == '1')
                secretHandshake.Add("close your eyes");
            if (numbers[3] == '1')
                secretHandshake.Add("double blink");
            if (numbers[4] == '1')
                secretHandshake.Add("wink");
        }
        else
        {
            if (numbers.Length == 5)
            {
                if (numbers[4] == '1')
                secretHandshake.Add("wink");
                if (numbers[3] == '1')
                    secretHandshake.Add("double blink");
                if (numbers[2] == '1')
                    secretHandshake.Add("close your eyes");
                if (numbers[1] == '1')
                    secretHandshake.Add("jump");
            }
            else if (numbers.Length == 4)
            {
                if (numbers[3] == '1')
                secretHandshake.Add("wink");
                if (numbers[2] == '1')
                    secretHandshake.Add("double blink");
                if (numbers[1] == '1')
                    secretHandshake.Add("close your eyes");
                if (numbers[0] == '1')
                    secretHandshake.Add("jump");
            }
            else if (numbers.Length == 3)
            {
                if (numbers[2] == '1')
                secretHandshake.Add("wink");
                if (numbers[1] == '1')
                    secretHandshake.Add("double blink");
                if (numbers[0] == '1')
                    secretHandshake.Add("close your eyes");
            }
            else if (numbers.Length == 2)
            {
                if (numbers[1] == '1')
                secretHandshake.Add("wink");
                if (numbers[0] == '1')
                    secretHandshake.Add("double blink");
            }
            else if (numbers.Length == 1)
            {
                if (numbers[0] == '1')
                secretHandshake.Add("wink");
            }
        }

        string[] commands = secretHandshake.ToArray();

        return commands;
    }
}