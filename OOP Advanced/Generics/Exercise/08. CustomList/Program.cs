using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var cmd = input[0];
                if (cmd == "END")
                {
                    break;
                }

                switch (cmd)
                {
                    case "Add":
                        customList.Add(input[1]);
                        break;
                    case "Remove":
                        Console.WriteLine(customList.Remove(int.Parse(input[1])));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(input[1]).ToString());
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(input[1]), int.Parse(input[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(input[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        Console.WriteLine(customList.ToString());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
