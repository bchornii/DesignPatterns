using System;

namespace _02_Memento_robot
{
    internal class Program
    {
        private static void Main()
        {
            var david = new Man();
            var asimo = new Robot();

            david.State = "Jeans";
            Console.WriteLine($"State : {david.State}");            

            asimo.Backpack = david.CreateMenento();

            david.State = "Shorts";
            Console.WriteLine($"State : {david.State}");

            david.SetMemento(asimo.Backpack);
            Console.WriteLine($"State : {david.State}");

            Console.Read();
        }
    }
}
