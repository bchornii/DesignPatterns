using System.Collections;

namespace _01_Iterator_Dinner
{
    public class PancakeHouseMenu : IIteratable
    {
        private readonly ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();
            AddItem("Pancake 1", "Bacon with lettuce", false, 2.99);
            AddItem("Pancake 2", "Bacon with tomato", false, 2.89);
            AddItem("Pancake 3", "Soup with meat", false, 1.12);
        }

        public void AddItem(string name, string descr, bool vegeterian, double price)
        {
            _menuItems.Add(new MenuItem(name, descr, vegeterian, price));
        }

        public ArrayList GetItems()
        {
            return _menuItems;
        }

        public IIterator GetIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
    }
}
