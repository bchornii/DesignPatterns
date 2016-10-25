using System;

namespace _02_Memento_robot
{
    internal class Program
    {
        private static void Main()
        {
            var david = new Man();
            var asimo = new Robot();

            Console.WriteLine($"State : {david.State}");            
            asimo.Backpack = david.Undress();

            david.ChangeClose();

            Console.WriteLine($"State : {david.State}");
            david.Dress(asimo.Backpack);

            Console.WriteLine($"State : {david.State}");

            Console.Read();
        }
    }
}
