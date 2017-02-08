using System;

namespace _03_ChainOfResponsibility_Bank
{
    public class Manager : IRequestHandler
    {
        public string Name { get; set; }
        public IRequestHandler Successor { get; set; }
        public void HandleRequest(LoanRequest req)
        {
            if (req.Amount < 10000)
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
