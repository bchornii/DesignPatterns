using System;

namespace _01_Iterator_Dinner
{
    internal class Program
    {
        private static void Main()
        {
            var pancakeMenu = new PancakeHouseMenu();
            var dinnerMenu = new DinnerMenu();

            var waitress = new Waitress(pancakeMenu, dinnerMenu);
            waitress.PrintMenu();

            Console.Read();
        }
    }
}
