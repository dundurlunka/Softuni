using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Celebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IBirthable>();

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0]=="End")
                {
                    break;
                }
                else if (input.Length == 5)
                {
                    var name = input[1];
                    var age = int.Parse(input[2]);
                    var id = input[3];
                    var birthdate = input[4];
                    var citizen = new Citizen(id, name, age, birthdate);
                    list.Add(citizen);
                }
                else if(input[0] == "Pet")
                {
                    var name = input[1];
                    var birthdate = input[2];
                    var pet = new Pet(name, birthdate);
                    list.Add(pet);
                }
            }

            var year = Console.ReadLine();

            foreach (var item in list.Where(i => i.Birthdate.EndsWith(year)))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
