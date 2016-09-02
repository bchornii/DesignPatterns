using System;

namespace _01_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var doctorDream = new AmbulanceCar(new TurboCar(new Mercedes()));
            doctorDream.Go();

            Console.Read();
        }
    }
}
