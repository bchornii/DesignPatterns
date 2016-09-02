using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory_GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cocaColaClient = new Client(new CocaColaFactory());
            cocaColaClient.Interact();

            Client pepsiClient = new Client(new PepsiFactory());
            pepsiClient.Interact();

            Console.ReadLine();
        }
    }
}
