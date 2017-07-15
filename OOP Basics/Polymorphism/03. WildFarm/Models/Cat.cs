using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Models
{
    public class Cat : Felime
    {
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }


        public Cat(string animalType, string animalName, double animalWeight, string livinRegion, string breed) : base(animalType, animalName, animalWeight, livinRegion)
        {
            this.Breed = breed;
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"Cat[{this.AnimalName}, {this.breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
