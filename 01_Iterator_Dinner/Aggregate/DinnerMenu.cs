using System;

namespace _01_Iterator_Dinner
{
    public class DinnerMenu : IIteratable
    {
        private const int maxItems = 6;
        private int _numberOfItems = 0;
        private readonly MenuItem[] _menuItems;

        public MenuItem this[int index] => _menuItems[index];
        public int Length => _menuItems.Length;

        public DinnerMenu()
        {
            _menuItems = new MenuItem[maxItems];
            AddItem("Vegeterian BLT", "Bacon with lettuce", false, 2.99);
            AddItem("BLT","Bacon with tomato", false, 2.89);
            AddItem("Soup of the day","Soup with meat",false, 1.12);
        }

        public void AddItem(string name, string descr, bool vegeterian, double price)
        {
            if (_numberOfItems >= maxItems)
            {
                Console.WriteLine("Sorry, menu is full!!!");
            }
            else
            {
                _menuItems[_numberOfItems] = new MenuItem(name,descr,vegeterian,price);
                _numberOfItems++;
            }
        }

        public MenuItem[] GetItems()
        {
            return _menuItems;
        }

        public IIterator GetIterator()
        {
            return new DinnerMenuIterator(this);
        }
    }
}
