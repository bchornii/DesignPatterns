using System;

namespace _01_Iterator_Dinner
{
    public class Waitress
    {
        private readonly IIteratable _pancakeHouseMenu;
        private readonly IIteratable _dinnerMenu;

        public Waitress(IIteratable pancakeHouseMenu, IIteratable dinnerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinnerMenu = dinnerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.GetIterator();
            var dinnerIterator = _dinnerMenu.GetIterator();
            Console.WriteLine("MENU\n----BREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\n----LUNCH");
            PrintMenu(dinnerIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var item = iterator.Next() as MenuItem;
                Console.WriteLine($"{item?.Name}, {item?.Price},{item?.Description}");
            }
        }
    }
}
