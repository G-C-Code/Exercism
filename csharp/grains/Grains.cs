using System;

public static class Grains
{
    public static ulong Square(int n) => n > 64 || n < 1
    ? throw new ArgumentOutOfRangeException()
    : 1 * (ulong)Math.Pow(2, n - 1);

    public static ulong Total() => (ulong)Math.Pow(2, 64) - 1;
}