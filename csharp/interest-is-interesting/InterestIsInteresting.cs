using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate = 0f;

        if (balance < 0)
            interestRate = 3.213f;
        else if (balance < 1000)
            interestRate = 0.5f;
        else if (balance < 5000)
            interestRate = 1.621f;
        else
            interestRate = 2.475f;

        return interestRate;
    }

    public static decimal Interest(decimal balance)
    {
        decimal interest = 0;

        if (balance < 0)
            interest = balance * (decimal) 0.03213f;
        else if (balance < 1000)
            interest = balance * (decimal) 0.005f;
        else if (balance < 5000)
            interest = balance * (decimal) 0.01621f;
        else
            interest = balance * (decimal) 0.02475f;

        return interest;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal annualBalanceUpdate = balance + SavingsAccount.Interest(balance);
        return annualBalanceUpdate;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearsBeforeDesiredBalance = 0;
        while (balance <= targetBalance)
            {
                balance += SavingsAccount.Interest(balance);
                yearsBeforeDesiredBalance++;
            }
        return yearsBeforeDesiredBalance;
    }
}
