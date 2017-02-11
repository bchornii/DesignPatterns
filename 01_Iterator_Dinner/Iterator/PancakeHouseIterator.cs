namespace _01_Iterator_Dinner
{
    public class PancakeHouseIterator : IIterator
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private int _position = 0;

        public PancakeHouseIterator(PancakeHouseMenu pancakeHouseMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
        }

        public bool HasNext()
        {
            return _position < _pancakeHouseMenu.Count && _pancakeHouseMenu[_position] != null;
        }

        public object Next()
        {
            var item = _pancakeHouseMenu[_position];
            _position++;
            return item;
        }
    }
}