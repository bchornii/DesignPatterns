using System;

namespace _01_Decorator
{
    internal class Program
    {
        private static void Main()
        {
            var doctorDream = new AmbulanceCar(new TurboCar(new Mercedes()));
            doctorDream.Go();

            Console.Read();
        }
    }
}
