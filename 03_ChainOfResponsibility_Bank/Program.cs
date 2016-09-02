using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChainOfResponsibility_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customers
            var req1 = new LoanRequest { Customer = "John Tanta", Amount = 800 };
            var req2 = new LoanRequest { Customer = "Big Dad", Amount = 1800 };
            var req3 = new LoanRequest { Customer = "Cally Minou", Amount = 11800 };

            // Approvers
            var supermanager = new SuperManager { Name = "Grag, super manager" };
            var manager = new Manager { Name = "Stiv, manager" , Successor = supermanager};
            var cashier = new Cashier { Name = "Job, cashier", Successor = manager };

            // handle requests
            cashier.HandleRequest(req1);
            cashier.HandleRequest(req2);
            cashier.HandleRequest(req3);

            Console.ReadLine();
        }
    }
}
