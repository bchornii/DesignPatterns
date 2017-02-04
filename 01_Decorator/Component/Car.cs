using System;

namespace _01_Decorator
{
    public class Car
    {
        protected string Brand { get; set; }
        public virtual void Go()
        {
            Console.WriteLine("I'm " + Brand + " and I'm on my way.");
        }
    }
}
