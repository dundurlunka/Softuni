using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBox
{
    public static class Counter
    {
        public static int Count<T>(List<Box<T>> list, T element)
            where T : IComparable<T>
        {
            return list.Where(p => p.Value.CompareTo(element) > 0).Count();
        }
    }
}
