using _09.CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierarchy.Models
{
    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        private List<string> removeResults;

        public AddRemoveCollection()
        {
            this.List = new List<string>();
            this.RemoveResults = new List<string>();
        }

        public List<string> RemoveResults { get => removeResults; private set => removeResults = value; }

        public override void Add(string element)
        {
            this.List.Insert(0, element);
            this.AddResults.Add(0);
        }

        public virtual void Remove()
        {
            var element = this.List[this.List.Count - 1];
            this.List.RemoveAt(this.List.Count - 1);
            this.RemoveResults.Add(element);
        }
    }
}
