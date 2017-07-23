using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Citizen>();

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                var citizen = new Citizen(input[0], input[1], int.Parse(input[2]));
                people.Add(citizen);
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
