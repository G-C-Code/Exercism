using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var t in collection)
        {
            yield return func(t);
        }
    }
}
