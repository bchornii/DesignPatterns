namespace _01_Iterator_Dinner
{
    public class DinnerMenuIterator : IIterator
    {
        private readonly MenuItem[] _menuItems;
        private int _position;

        public DinnerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {            
            return _position < _menuItems.Length && _menuItems[_position] != null;
        }

        public object Next()
        {
            var item = _menuItems[_position];
            _position++;
            return item;
        }
    }
}