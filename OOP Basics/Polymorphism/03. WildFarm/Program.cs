using _03.WildFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var animalArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if(animalArr[0] == "End")
                {
                    break;
                }

                Animal animal = null;
                switch (animalArr[0])
                {
                    case "Cat":
                        animal = new Cat(animalArr[0], animalArr[1], double.Parse(animalArr[2]), animalArr[3], animalArr[4]);
                        break;
                    case "Tiger":
                        animal = new Tiger(animalArr[0], animalArr[1], double.Parse(animalArr[2]), animalArr[3]);
                        break;
                    case "Mouse":
                        animal = new Mouse(animalArr[0], animalArr[1], double.Parse(animalArr[2]), animalArr[3]);
                        break;
                    case "Zebra":
                        animal = new Zebra(animalArr[0], animalArr[1], double.Parse(animalArr[2]), animalArr[3]);
                        break;
                    default:
                        break;
                }

                Food food = null;
                var foodArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (foodArr[0])
                {
                    case "Vegetable":
                        food = new Vegetable(int.Parse(foodArr[1]));
                        break;
                    case "Meat":
                        food = new Meat(int.Parse(foodArr[1]));
                        break;
                    default:
                        break;
                }
                animal.MakeSound();
                try
                {
                    animal.Eat(food);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
