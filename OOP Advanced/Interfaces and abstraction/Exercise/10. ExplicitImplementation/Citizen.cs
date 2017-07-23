using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExplicitImplementation
{
    public class Citizen : IPerson, IResident
    {
        private string name;
        private string country;
        private int age;

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name { get => name; private set => name = value; }
        public string Country { get => country; private set => country = value; }
        public int Age { get => age; private set => age = value; }

        string IPerson.GetName()
        {
            return this.Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        public override string ToString()
        {
            IPerson personCitizen = (IPerson)this;
            IResident residentCitizen = (IResident)this;
            var sb = new StringBuilder();
            sb.AppendLine(personCitizen.GetName());
            sb.AppendLine(residentCitizen.GetName());
            return sb.ToString().Trim();
        }
    }
}
