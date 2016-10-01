using System;
using System.Collections;

namespace _03_Composite_Menu
{
    public class MenuItem : IMenuComponent
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegeterian { get; }
        public double Price { get; }

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            Name = name;
            Description = description;
            Vegeterian = vegeterian;
            Price = price;
        }

        public string GetName() => Name;
        public string GetDescription() => Description;
        public bool IsVegeterian() => Vegeterian;
        public double GetPrice() => Price;        
        public void Print()
        {
            Console.Write($" {Name}");
            if (Vegeterian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine();
            Console.WriteLine($"   -- {Price}");
            Console.WriteLine($"   -- {Description}");
        }
    }
}
