using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        return new T[length];
    }
}

