using _09.CollectionHierarchy.Interfaces;
using _09.CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();
            foreach (var el in elements)
            {
                addCollection.Add(el);
                addRemoveCollection.Add(el);
                myList.Add(el);
            }
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                addRemoveCollection.Remove();
                myList.Remove();
            }
            Console.WriteLine(string.Join(" ", addCollection.AddResults));
            Console.WriteLine(string.Join(" ", addRemoveCollection.AddResults));
            Console.WriteLine(string.Join(" ", myList.AddResults));

            Console.WriteLine(string.Join(" ", addRemoveCollection.RemoveResults));
            Console.WriteLine(string.Join(" ", myList.RemoveResults));
        }
    }
}
