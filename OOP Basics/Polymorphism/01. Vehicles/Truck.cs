using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance, bool modifierExist)
        {
            var neededFuel = distance * (this.FuelConsupmtion + 1.6);
            if (this.FuelQuantity < neededFuel)
            {
                Output.NotEnoughFuel("Truck");
            }
            else
            {
                this.FuelQuantity -= neededFuel;
                Output.TravelledDistance("Truck", distance);
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += 0.95 * liters;
        }

        public override string ToString()
        {
            return "Truck" + base.ToString();
        }
    }
}
