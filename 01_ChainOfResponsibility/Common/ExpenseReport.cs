namespace _01_ChainOfResponsibility
{
    public class ExpenseReport : IExpenseReport
    {
        public decimal Total { get; }
        public ExpenseReport(decimal total)
        {
            Total = total;
        }        
    }
}