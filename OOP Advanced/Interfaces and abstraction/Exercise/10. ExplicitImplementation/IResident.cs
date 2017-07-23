using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExplicitImplementation
{
    public interface IResident
    {
        string Name { get; }

        string Country { get; }

        string GetName();
    }
}
