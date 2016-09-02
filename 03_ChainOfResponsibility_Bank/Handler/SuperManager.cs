using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChainOfResponsibility_Bank
{
    class SuperManager : IRequestHandler
    {
        public string Name { get; set; }
        public IRequestHandler Successor { get; set; }
        public void HandleRequest(LoanRequest req)
        {
            if (req.Amount < 100000)
            {
                Console.WriteLine("{0}$ loan approved for {1} by {2}", req.Amount, req.Customer, Name);
            }
            else
            {
                this.TrySuccessor(req);
            }
        }
    }
}
