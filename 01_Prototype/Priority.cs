using System;

namespace _01_Prototype
{
    class Priority : IClonable<Priority>
    {
        private int priority = -1;
        
        public Priority Hight()
        {
            priority = 1;
            return this;
        }       

        public Priority Low()
        {
            priority = 2;
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

        public int Prior
        {
            get { return priority; }
        }
    }
}
