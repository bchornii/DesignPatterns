using System;

namespace _02_Prototype_Maze
{
    public class Wall : IClonable<Wall>
    {
        public virtual Wall Clone()
        {
            throw new NotImplementedException();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}