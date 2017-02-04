using System;

namespace _02_Decorator_Coffe
{
    public abstract class Coffe
    {
        public string Name { get; set; }
        public virtual void Make()
        {
            Console.WriteLine("Type : " + Name);
        }
    }
}
