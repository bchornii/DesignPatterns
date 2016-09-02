using System;

namespace _03_ChainOfResponsibility_Bank
{
    static class RequestHandlerExtension
    {
        public static void TrySuccessor(this IRequestHandler handler, LoanRequest req)
        {
            if (handler.Successor != null)
            {
                Console.WriteLine("{0} can't approve. Pass request to {1}", handler.Name, handler.Successor.Name);
                handler.Successor.HandleRequest(req);
            }
            else
            {
                Console.WriteLine("Handler has no approval. You need some big boss");
            }
        }
    }
}
