using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IBuyer>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 3)
                {
                    var name = input[0];
                    var age = int.Parse(input[1]);
                    var group = input[2];
                    var rebel = new Rebel(name, age, group);
                    list.Add(rebel);
                }
                else if (input.Length==4)
                {
                    var name = input[0];
                    var age = int.Parse(input[1]);
                    var id = input[2];
                    var birthdate = input[3];
                    var citizen = new Citizen(id, name, age, birthdate);
                    list.Add(citizen);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                if (list.Any(i => i.Name == input))
                {
                    list.Where(i => i.Name == input).First().BuyFood();
                }
            }
            Console.WriteLine(list.Sum(i => i.Food));
        }
    }
}
