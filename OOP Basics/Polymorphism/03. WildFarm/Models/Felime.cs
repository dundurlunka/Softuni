using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Models
{
    public abstract class Felime : Mammal
    {
        public Felime(string animalType, string animalName, double animalWeight, string livinRegion) : base(animalType, animalName, animalWeight, livinRegion)
        {
        }
    }
}
