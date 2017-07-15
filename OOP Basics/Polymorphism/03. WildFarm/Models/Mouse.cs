using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string livinRegion) : base(animalType, animalName, animalWeight, livinRegion)
        {
        }

        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;
            if(foodName != "Vegetable")
            {
                throw new ArgumentException("Mouses are not eating that type of food!");
            }
            this.FoodEaten += food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override string ToString()
        {
            return "Mouse" + base.ToString();
        }
    }
}
