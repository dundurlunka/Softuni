using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance, bool modifierExists)
        {
            double neededFuel;
            if (modifierExists)
            {
                neededFuel = distance * (this.FuelConsupmtion + 1.4);
            }
            else
            {
                neededFuel = distance * this.FuelConsupmtion;
            }
            
            if (this.FuelQuantity < neededFuel)
            {
                Output.NotEnoughFuel("Bus");
            }
            else
            {
                this.FuelQuantity -= neededFuel;
                Output.TravelledDistance("Bus", distance);
            }
        }

        public override void Refuel(double liters)
        {
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Output.TooSmallFuelTank();
                return;
            }
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return "Bus" + base.ToString();
        }
    }
}
