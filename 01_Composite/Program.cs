using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new DocumentComponent("Document");
            var body = new DocumentComponent("Body");
            document.AddComponent(body);

            var customerDocumentSection = new CustomerDocumentComponent(41);
            var orders = new DocumentComponent("Orders");
            var order1 = new OrderDocumentComponent(0);
            var order2 = new OrderDocumentComponent(1);
            orders.AddComponent(order1);
            orders.AddComponent(order2);

            body.AddComponent(customerDocumentSection);
            body.AddComponent(orders);

            string gatherData = document.GatherData();
            Console.WriteLine(gatherData);

            Console.ReadLine();
        }
    }
}
