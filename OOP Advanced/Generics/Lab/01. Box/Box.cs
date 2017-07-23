using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public int Count { get => this.data.Count; }

    public T Remove()
    {
        var element = this.data[0];
        this.data.RemoveAt(0);
        return element;
    }

    public void Add(T element)
    {
        this.data.Insert(0, element);
    }
}

