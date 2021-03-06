﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Celebrations
{
    public class Citizen : IIdentifiable, IBirthable
    {
        private string id;
        private string name;
        private int age;
        private string birthdate;

        public Citizen(string id, string name, int age, string birthdate)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
    }
}
