using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public SortedDictionary<string, int> Enrolled = new();
    public bool Add(string student, int grade) => Enrolled.TryAdd(student, grade);

    public IEnumerable<string> Roster()
    {
        if(Enrolled.Count < 1)
            return new List<string>();

        List<string> roster = new();

        for (int i = 1; i <= Enrolled.Values.Max(); i++)
            foreach(var e in Enrolled)
                if(e.Value == i)
                    roster.Add(e.Key);
        
        return roster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        List<string> studentsInGrade = new();

        foreach(var e in Enrolled)
            if(e.Value == grade)
                studentsInGrade.Add(e.Key);

        return studentsInGrade;
    }
}