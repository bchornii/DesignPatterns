using System;

namespace _02_Prototype_Maze
{
    public interface IClonable<T> : ICloneable
    {
        new T Clone();
    }
}