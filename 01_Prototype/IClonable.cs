using System;

namespace _01_Prototype
{
    interface IClonable<T> : ICloneable
    {
        new T Clone();
    }
}
