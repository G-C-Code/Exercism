using System;
using System.Collections;
using System.Collections.Generic;

public class BinarySearchTree : IEnumerable<int>
{
    public int Value { get; private set; }
    public BinarySearchTree Left { get; private set; }
    public BinarySearchTree Right { get; private set; }
    public BinarySearchTree(int value) => Value = value;

    public BinarySearchTree(IEnumerable<int> values)
    {
        var enumerator = values.GetEnumerator();
        if (enumerator.MoveNext())
        {
            Value = enumerator.Current;
            while (enumerator.MoveNext())
                Add(enumerator.Current);
        }
    }

    public void Add(int value)
    {
        if (value <= Value)
        {
            if (Left == null)
                Left = new BinarySearchTree(value);
            else
                Left.Add(value);
        }
        else
        {
            if (Right == null)
                Right = new BinarySearchTree(value);
            else
                Right.Add(value);
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        if (Left != null)
            foreach (var value in Left)
                yield return value;

        yield return Value;

        if (Right != null)
            foreach (var value in Right)
                yield return value;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
