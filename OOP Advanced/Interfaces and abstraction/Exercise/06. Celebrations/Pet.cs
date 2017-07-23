using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Celebrations
{
    public class Pet : IBirthable
    {
        private string birthdate;
        private string name;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Name { get => name; set => name = value; }
    }
}
