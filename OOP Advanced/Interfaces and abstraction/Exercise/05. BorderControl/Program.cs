using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IIdentifiable>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0]=="End")
                {
                    break;
                }
                if (input.Length == 2)
                {
                    var model = input[0];
                    var id = input[1];
                    list.Add(new Robot(id, model));
                }
                else
                {
                    var name = input[0];
                    var age = int.Parse(input[1]);
                    var id = input[2];
                    list.Add(new Citizen(id, name, age));
                }
            }
            var lastSymbols = Console.ReadLine();
            foreach (var item in list)
            {
                if(item.Id.Substring(item.Id.Length-lastSymbols.Length, lastSymbols.Length) == lastSymbols)
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
