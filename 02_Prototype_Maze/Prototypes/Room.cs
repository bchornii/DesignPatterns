using System;

namespace _02_Prototype_Maze
{
    public class Room : IClonable<Room>
    {
        private int _number;

        public void Initialize(int number)
        {
            _number = number;
        }

        public virtual Room Clone()
        {
            throw new NotImplementedException();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}