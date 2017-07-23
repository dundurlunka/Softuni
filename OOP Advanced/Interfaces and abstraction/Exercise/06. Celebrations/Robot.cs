using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Celebrations
{
    public class Robot : IIdentifiable
    {
        private string id;
        private string model;

        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }

        public string Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
    }
}
