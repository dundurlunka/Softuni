using _09.CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierarchy.Models
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public int Used { get => this.List.Count; }

        public override void Remove()
        {
            var element = this.List[0];
            this.List.RemoveAt(0);
            this.RemoveResults.Add(element);
        }
    }
}
