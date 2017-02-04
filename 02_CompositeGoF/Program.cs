using System;

namespace _02_CompositeGoF
{
    internal class Program
    {
        private static void Main()
        {
            var document = new Composite("Document");
            var body = new Composite("Body");
            document.Add(body);

            var customer1 = new CustomerComponent(0);
            var customer2 = new CustomerComponent(1);            

            var orders = new Composite("Orders");
            var order1 = new OrderComponent(0);
            var order2 = new OrderComponent(1);
            orders.Add(order1);
            orders.Add(order2);

            body.Add(customer1);
            body.Add(orders);      

            string gatherData = document.GatherData();
            Console.WriteLine(gatherData);
            Console.ReadLine();
        }
    }
}
