using System;
using System.Collections.Generic;

namespace _03_Composite_Menu
{
    public class Menu : IMenuComposite
    {
        private readonly string _name;
        private readonly string _description;
        private readonly IList<IMenuComponent> _menuComponents = new List<IMenuComponent>();
        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Add(IMenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public void Remove(IMenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public IMenuComponent GetChild(int i)
        {
            return i < _menuComponents.Count ? _menuComponents[i] : null;
        }
        
        public string GetName() => _name;
        public string GetDescription() => _description;
        public double GetPrice()
        {
            throw new InvalidOperationException();
        }

        public bool IsVegeterian()
        {
            throw new InvalidOperationException();
        }

        public void Print()
        {
            Console.Write($"\n {GetName()} : ");
            Console.WriteLine($"{GetDescription()}");
            Console.WriteLine(new string('-', 80));

            foreach (var menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }       
    }
}
