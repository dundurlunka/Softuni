using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Models
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalType, string animalName, double animalWeight, string livinRegion) : base(animalType, animalName, animalWeight)
        {
            this.LivingRegion = livinRegion;
        }

        public string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.livingRegion}, {this.FoodEaten}]";
        }
    }
}
