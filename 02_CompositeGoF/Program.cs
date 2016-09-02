using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CompositeGoF
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Component("Document");
            var body = new Component("Body");
            document.Add(body);

            var customer1 = new CustomerComponent(0);
            var customer2 = new CustomerComponent(1);            

            var orders = new Component("Orders");
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
