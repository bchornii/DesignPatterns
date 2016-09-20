using System;

namespace _03_AbstractFacroty_Ingredient
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25min");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza in slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
        public virtual void Pack()
        {
            Console.WriteLine("Packing pizza");
        }
    }
}
