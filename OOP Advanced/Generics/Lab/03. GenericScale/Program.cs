using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var scale = new Scale<int>(5, 10);

        Console.WriteLine(scale.GetHavier());
    }
}

