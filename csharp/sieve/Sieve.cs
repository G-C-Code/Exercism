using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 0)
            throw new ArgumentOutOfRangeException();

        var isPrime = new bool[limit + 1];

        for (int i = 2; i <= limit; i++)
            isPrime[i] = true;

        for (int i = 2; i * i <= limit; i++)
            if (isPrime[i])
                for (int j = i * i; j <= limit; j += i)
                    isPrime[j] = false;

        List<int> primes = new List<int>();

        for (int i = 2; i <= limit; i++)
            if (isPrime[i])
                primes.Add(i);

        return primes.ToArray();
    }
}
