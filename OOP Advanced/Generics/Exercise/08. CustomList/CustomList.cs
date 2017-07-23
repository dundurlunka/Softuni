using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CustomList
{
    public class CustomList<T>
        where T : IComparable<T>
    {
        private IList<T> data;

        public CustomList()
        {
            this.Data = new List<T>();
        }

        public IList<T> Data { get => data; private set => data = value; }

        public void Add(T element)
        {
            this.Data.Add(element);
        }

        public T Remove(int index)
        {
            var element = this.Data[index];
            this.Data.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return this.Data.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            var firstElement = this.data[index1];
            var secondElement = this.data[index2];
            this.data[index1] = secondElement;
            this.data[index2] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            return this.Data.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.Data.Max();
        }

        public T Min()
        {
            return this.Data.Min();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var el in this.Data)
            {
                sb.AppendLine(el.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
