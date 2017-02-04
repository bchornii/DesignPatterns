using System;


/* 
 * In this project we have Composite pattern example which implemented
 * with opt to safety rather than transparency.
 */
namespace _03_Composite_Menu
{
    internal class Program
    {
        private static void Main()
        {
            var item1 = new MenuItem("Sour","Super soup",true,1.10);
            var item2 = new MenuItem("Meat", "Super meat", true, 1.10);
            var item3 = new MenuItem("Diag", "Super diag", true, 1.10);

            var dinnermenu = new Menu("Dinner menu", "");
            dinnermenu.Add(item1);
            dinnermenu.Add(item2);
            dinnermenu.Add(item3);

            var item4 = new MenuItem("Tea","Super tea", false, 0.8);
            var item5 = new MenuItem("Coffe","Super coffe",false, 0.99);

            var drinkMenu = new Menu("Drink menu","");
            drinkMenu.Add(item4);
            drinkMenu.Add(item5);

            var fullMenu = new Menu("Complete menu","Contains drink and dinner menu");         
            fullMenu.Add(dinnermenu);
            fullMenu.Add(drinkMenu);            

            var waitress = new Waitress(fullMenu);
            waitress.PrintMenu();            

            Console.Read();
        }
        
    }
}
