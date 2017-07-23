using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartphone = new Smartphone();
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var num in numbers)
            {
                smartphone.Numbers.Add(num);
            }

            var urls = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var url in urls)
            {
                smartphone.Urls.Add(url);
            }

            Console.WriteLine(smartphone.ToString());
        }
    }
}
