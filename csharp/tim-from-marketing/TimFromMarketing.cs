using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string print = "";
        
        if (id != null)
            print += $"[{id}] - ";
        if (department != null)
            print += $"{name} - {department?.ToUpper()}";
        else
            print += $"{name} - OWNER";

        return print;
    }
}
