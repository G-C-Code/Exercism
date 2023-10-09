using System;
using System.Reflection;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string AnalyzeOffField(object report)
    {
        string offField = "";
        switch (report)
        {
            case int:
                return $"There are {report} supporters at the match.";
            case string:
                return (string)report;
            case Incident incident:
                if (incident.GetType() == typeof(Foul))
                    return incident.GetDescription();
                else if (incident.GetType() == typeof(Injury))
                    return $"Oh no! {incident.GetDescription()} Medics are on the field.";
                else
                    return incident.GetDescription();
            case Manager manager:
                if (manager.Club != null)
                    return offField = $"{manager.Name} ({manager.Club})";
                else
                    return manager.Name;
            default:
                throw new ArgumentException();
        }
    }
}
