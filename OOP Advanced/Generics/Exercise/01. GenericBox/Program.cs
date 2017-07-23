using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                var value = Console.ReadLine();
                //Box<string> box = new Box<string>(value);
                Box<double> box = new Box<double>(double.Parse(value));
                list.Add(box);
            }
            var element = double.Parse(Console.ReadLine());
            var counter = Counter.Count(list, element);
            Console.WriteLine(counter);
            
        }
    }
}
