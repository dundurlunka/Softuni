using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public static class Output
    {
        public static void NotEnoughFuel(string vehicle)
        {
            Console.WriteLine($"{vehicle} needs refueling");
        }

        public static void TravelledDistance(string vehicle, double kilometres)
        {
            Console.WriteLine($"{vehicle} travelled {kilometres} km");
        }

        public static void TooSmallFuelTank()
        {
            Console.WriteLine("Cannot fit fuel in tank");
        }

        public static void NegativeFuel()
        {
            Console.WriteLine("Fuel must be a positive number");
        }
    }
}
