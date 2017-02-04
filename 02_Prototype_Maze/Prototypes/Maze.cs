using System;

namespace _02_Prototype_Maze
{
    public class Maze : IClonable<Maze>
    {
        public virtual Maze Clone()
        {
            throw new NotImplementedException();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}