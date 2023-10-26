using System;
using System.Collections.Generic;

public class DndCharacter
{
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public DndCharacter()
    {
        Strength = Ability();
        Dexterity = Ability();
        Constitution = Ability();
        Intelligence = Ability();
        Wisdom = Ability();
        Charisma = Ability();
        Hitpoints = 10 + Modifier(Constitution);
    }

    private static readonly Random dice = new Random();

    public static int Modifier(int score) => (int)Math.Floor((score - 10)/2.0);

    public static int Ability() 
    {
        int diceOne = dice.Next(1, 7);
        int diceTwo = dice.Next(1, 7);
        int diceThree = dice.Next(1, 7);
        int diceFour = dice.Next(1, 7);
        
        List<int> diceSum = new List<int> { diceOne, diceTwo, diceThree, diceFour };

        diceSum.Sort();
        
        return diceSum[1] + diceSum[2] + diceSum[3];
    }

    public static DndCharacter Generate() => new DndCharacter();
}
