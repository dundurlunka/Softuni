using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBox
{
    public static class Swapper
    {
        public static List<T> Swap<T>(List<T> list, int[] indeces)
        {
            var helpVar = list[indeces[1]];
            list[indeces[1]] = list[indeces[0]];
            list[indeces[0]] = helpVar;
            return list;
        } 
    }
}
