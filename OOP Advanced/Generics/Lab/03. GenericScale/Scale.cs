using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scale<T>
    where T : IComparable<T>
{
    private T first;
    private T second;

    public Scale(T first, T second)
    {
        this.First = first;
        this.Second = second;
    }

    public T First { get => first; set => first = value; }
    public T Second { get => second; set => second = value; }

    public T GetHavier()
    {
        if(this.First.CompareTo(this.Second) > 0)
        {
            return this.First;
        }
        else if(this.First.CompareTo(this.Second) < 0)
        {
            return this.Second;
        }

        return default(T);
    }
}

