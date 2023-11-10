using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{    
    public string Diagram;
    public string FirstHalf;
    public string SecondHalf;
    
    public KindergartenGarden(string diagram)
    {
        Diagram = Regex.Replace(diagram, "[^A-Z]", "");

        if(Diagram.Length % 2 != 0)
            throw new ArgumentException();

        FirstHalf = Diagram.Substring(0, Diagram.Length/2);
        SecondHalf = Diagram.Substring(FirstHalf.Length);
    }

    public IEnumerable<Plant> Plants(string student)
    {
        if(student != String.Empty)
        {
            List<Plant> plants = new List<Plant>();
            StringBuilder sb = new();

            int j = 0;
            int k = 1;

            for (int i = 65; i < 78; i++)
            {
                if(student[0] == (char)i)
                {
                    sb.Append(FirstHalf[j]);
                    sb.Append(FirstHalf[k]);
                    sb.Append(SecondHalf[j]);
                    sb.Append(SecondHalf[k]);
                }

                j += 2;
                k += 2;
            }

            foreach (char c in sb.ToString())
            {
                switch (c)
                {
                    case 'V':
                        plants.Add(Plant.Violets);
                        break;
                    case 'R':
                        plants.Add(Plant.Radishes);
                        break;
                    case 'C':
                        plants.Add(Plant.Clover);
                        break;
                    case 'G':
                        plants.Add(Plant.Grass);
                        break;
                }
            }

            return plants;
        }
        
        else
        {
            throw new ArgumentException();
        }
    }
}