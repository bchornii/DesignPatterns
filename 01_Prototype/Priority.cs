using System;

namespace _01_Prototype
{
    public class Priority : IClonable<Priority>
    {
        public int Prior { get; private set; } = -1;

        public Priority Hight()
        {
            Prior = 1;
            return this;
        }       

        public Priority Low()
        {
            Prior = 2;
            return this;
        }

        public Priority Clone()
        {
            return MemberwiseClone() as Priority;
        }

        object ICloneable.Clone()
        {
            return (this as IClonable<Priority>).Clone();
        }
    }
}
