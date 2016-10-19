using System;

namespace _02_State_Order
{
    internal class Program
    {
        private static void Main()
        {
            var order = new Order();
            Console.WriteLine($"Can ship = {order.CanShip()}");
            Console.WriteLine($"Can cancel = {order.CanCancel()}");

            Console.WriteLine("Ok : shipping...");
            order.Ship();
            Console.WriteLine($"Status = {order.Status}");

            Console.Read();
        }
    }
}
