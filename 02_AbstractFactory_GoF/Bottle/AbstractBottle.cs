﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory_GoF
{
    public abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
    }
}