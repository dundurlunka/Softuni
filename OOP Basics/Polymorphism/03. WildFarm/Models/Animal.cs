using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Models
{
    public abstract class Animal
    {
        private string animalName;

        private string animalType;

        private double animalWeight;

        private int foodEaten;

        public Animal(string animalType, string animalName, double animalWeight)
        {
            this.AnimalType = animalType;
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
        }

        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        public double AnimalWeight
        {
            get { return animalWeight; }
            set { animalWeight = value; }
        }

        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"[{this.animalName}, {this.animalWeight}, ";
        }
    }
}
