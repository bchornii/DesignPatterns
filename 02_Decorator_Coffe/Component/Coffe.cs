using System;

namespace _02_Decorator_Coffe
{
    abstract class Coffe
    {
        public string Name { get; set; }
        public virtual void Make()
        {
            Console.WriteLine("Type : " + Name);
        }
    }
}
