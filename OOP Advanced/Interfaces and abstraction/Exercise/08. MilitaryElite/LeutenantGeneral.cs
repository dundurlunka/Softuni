using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private List<ISoldier> privates;

        public LeutenantGeneral(int id, string firstName, string lastName, double salary) : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<ISoldier>();
        }

        public List<ISoldier> Privates { get => privates; private set => privates = value; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Privates:");
            foreach (var soldier in this.Privates)
            {
                sb.AppendLine($"  {soldier.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
