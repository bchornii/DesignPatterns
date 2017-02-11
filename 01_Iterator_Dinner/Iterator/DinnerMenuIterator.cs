namespace _01_Iterator_Dinner
{
    public class DinnerMenuIterator : IIterator
    {
        private readonly DinnerMenu _dinnerMenu;
        private int _position;

        public DinnerMenuIterator(DinnerMenu dinnerMenu)
        {
            _dinnerMenu = dinnerMenu;
        }

        public bool HasNext()
        {            
            return _position < _dinnerMenu.Length && _dinnerMenu[_position] != null;
        }

        public object Next()
        {
            var item = _dinnerMenu[_position];
            _position++;
            return item;
        }
    }
}