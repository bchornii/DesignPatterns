﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactory
{
    public abstract class Cat : AnimalToy
    {
        public Cat(string name) : base(name)
        {

        }
    }
}
