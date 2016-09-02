using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactory
{
    public abstract class Bear : AnimalToy
    {
        public Bear(string name) : base(name)
        {

        }
    }
}
