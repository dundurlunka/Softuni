using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBox
{
    public class Box<T>
        where T : IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get => value; private set => this.value = value; }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {value}";
        }
    }
}
