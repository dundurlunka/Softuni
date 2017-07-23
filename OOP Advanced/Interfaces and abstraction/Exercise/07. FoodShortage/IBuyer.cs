using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodShortage
{
    public interface IBuyer
    {
        int Food { get; }

        string Name { get; }

        void BuyFood();
    }
}
