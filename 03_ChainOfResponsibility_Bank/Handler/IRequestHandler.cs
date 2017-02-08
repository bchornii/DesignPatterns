namespace _03_ChainOfResponsibility_Bank
{
    public interface IRequestHandler
    {
        string Name { get; set; }
        IRequestHandler Successor { get; set; }
        void HandleRequest(LoanRequest req);        
    }
}
