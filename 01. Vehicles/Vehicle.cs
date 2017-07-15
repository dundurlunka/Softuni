using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsupmtion = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set
            {
                tankCapacity = value;
            }
        }

        public double FuelConsupmtion
        {
            get { return fuelConsumption; }
            set
            {
                fuelConsumption = value;
            }
        }


        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {

                if (value < 0)
                {
                    Output.NegativeFuel();
                    return;
                }
                fuelQuantity = value;
            }
        }

        public abstract void Drive(double distance, bool modifierExists);

        public abstract void Refuel(double liters);

        public override string ToString()
        {
            return $": {this.fuelQuantity:f2}";
        }
    }
}
