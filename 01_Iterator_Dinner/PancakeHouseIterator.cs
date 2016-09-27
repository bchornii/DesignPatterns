using System.Collections;

namespace _01_Iterator_Dinner
{
    public class PancakeHouseIterator : IIterator
    {
        private readonly ArrayList _menuItems;
        private int _position = 0;

        public PancakeHouseIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            return _position < _menuItems.Count && _menuItems[_position] != null;
        }

        public object Next()
        {
            var item = _menuItems[_position];
            _position++;
            return item;
        }
    }
}