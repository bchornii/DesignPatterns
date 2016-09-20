using System;

namespace _03_FactoryMethod_Abstract
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dogh ");
            Console.WriteLine("Adding sauce");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 min");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}
