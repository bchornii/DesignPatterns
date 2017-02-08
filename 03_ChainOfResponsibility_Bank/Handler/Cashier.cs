using System;

namespace _03_ChainOfResponsibility_Bank
{
    public class Cashier : IRequestHandler
    {
        public string Name { get; set; }
        public IRequestHandler Successor { get; set; }

        public void HandleRequest(LoanRequest req)
        {
            Console.WriteLine("\n---\n{0}$ loan requested by {1}", req.Amount, req.Customer);
            if (req.Amount < 1000)
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
