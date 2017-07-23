using _09.CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierarchy.Models
{
    public class AddCollection : IAddCollection
    {
        private List<string> list;
        private List<int> addResults;

        public AddCollection()
        {
            this.List = new List<string>();
            this.AddResults = new List<int>();
        }

        public List<string> List { get => list; set => list = value; }
        public List<int> AddResults { get => addResults; private set => addResults = value; }

        public virtual void Add(string element)
        {
            this.List.Add(element);
            this.AddResults.Add(this.List.Count - 1);
        }
    }
}
