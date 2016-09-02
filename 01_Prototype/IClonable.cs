using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Prototype
{
    interface IClonable<T> : ICloneable
    {
        new T Clone();
    }
}
