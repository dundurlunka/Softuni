using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmdParser = new CommandParser();

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }
                cmdParser.Parse(input);

            }

            foreach (var item in cmdParser.Soldiers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
