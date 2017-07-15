using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Models
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livinRegion) : base(animalType, animalName, animalWeight, livinRegion)
        {
        }

        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;
            if (foodName != "Vegetable")
            {
                throw new ArgumentException("Zebras are not eating that type of food!");
            }
            this.FoodEaten += food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }

        public override string ToString()
        {
            return "Zebra" + base.ToString();
        }
    }
}
