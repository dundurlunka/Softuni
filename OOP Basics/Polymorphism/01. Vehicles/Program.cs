using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicle carEntity = new Car(double.Parse(carArr[1]), double.Parse(carArr[2]), double.Parse(carArr[3]));

            var truckArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicle truckEntity = new Truck(double.Parse(truckArr[1]), double.Parse(truckArr[2]), double.Parse(truckArr[3]));

            var busArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicle busEntity = new Bus(double.Parse(busArr[1]), double.Parse(busArr[2]), double.Parse(busArr[3]));

            var cmdNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < cmdNumber; i++)
            {
                var cmdArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var vehicleType = cmdArr[1];
                var actionType = cmdArr[0];
                var number = double.Parse(cmdArr[2]);

                if (number <= 0)
                {
                    Output.NegativeFuel();
                    continue;
                }

                if (vehicleType == "Car")
                {
                    if (actionType == "Drive")
                    {
                        carEntity.Drive(number, false);
                    }
                    else
                    {
                        carEntity.Refuel(number);
                    }
                }
                else if(vehicleType == "Truck")
                {
                    if(actionType == "Drive")
                    {
                        truckEntity.Drive(number, false);
                    }
                    else
                    {
                        truckEntity.Refuel(number);
                    }
                }
                else if(vehicleType == "Bus")
                {
                    if (actionType == "Drive")
                    {
                        busEntity.Drive(number, true);
                    }
                    else if(actionType == "DriveEmpty")
                    {
                        busEntity.Drive(number, false);
                    }
                    else
                    {
                        busEntity.Refuel(number);
                    }
                }
            }
            Console.WriteLine(carEntity.ToString());
            Console.WriteLine(truckEntity.ToString());
            Console.WriteLine(busEntity.ToString());
        }
    }
}
