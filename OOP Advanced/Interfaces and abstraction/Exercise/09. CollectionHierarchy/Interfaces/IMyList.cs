﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierarchy.Interfaces
{
    public interface IMyList : IAddRemoveCollection
    {
        int Used { get; }
    }
}
