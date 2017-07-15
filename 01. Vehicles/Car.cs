using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void Drive(double distance, bool modifierExists)
        {
            var neededFuel = distance * (this.FuelConsupmtion+0.9);
            if(this.FuelQuantity < neededFuel)
            {
                Output.NotEnoughFuel("Car");
            }
            else
            {
                this.FuelQuantity -= neededFuel;
                Output.TravelledDistance("Car", distance);
            }
        }

        public override void Refuel(double liters)
        {
            if(this.FuelQuantity + liters > this.TankCapacity)
            {
                Output.TooSmallFuelTank();
                return;
            }
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return "Car" + base.ToString();
        }
    }
}
