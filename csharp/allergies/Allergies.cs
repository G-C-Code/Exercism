using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    public int Mask;
    public List<Allergen> allergens = new List<Allergen>();

    public Allergies(int mask) => Mask = mask;

    public bool IsAllergicTo(Allergen allergen) => (Mask & (int)allergen) != 0;

    public Allergen[] List()
    {
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
            if (IsAllergicTo(allergen))
                allergens.Add(allergen);

        return allergens.ToArray();
    }
}
