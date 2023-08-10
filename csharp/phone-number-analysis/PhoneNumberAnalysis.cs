using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = false;
        bool isFake = false;
        string localNumber = phoneNumber.Substring(8, 4);

        char[] numbers = phoneNumber.ToCharArray();

        if (numbers[0] == '2' && numbers[1] == '1' && numbers[2] == '2')
            isNewYork = true;

        if (numbers[4] == '5' && numbers[5] == '5' && numbers[6] == '5')
            isFake = true;

        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
