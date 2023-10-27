using System;
using System.Linq;
using System.Text;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        StringBuilder cleaned = new();

        foreach (char c in phoneNumber)
            if (char.IsDigit(c))
                cleaned.Append(c);


        if ((cleaned.Length > 11 || cleaned.Length < 10) || (cleaned.Length == 11 && cleaned[0] != '1'))
            throw new ArgumentException();
        else if (cleaned.Length == 11 && cleaned[0] == '1')
            cleaned.Remove(0, 1);

        if (cleaned[0] == '0' || cleaned[0] == '1' || cleaned[3] == '0' || cleaned[3] == '1')
            throw new ArgumentException();
        else
            return cleaned.ToString();

    }
}