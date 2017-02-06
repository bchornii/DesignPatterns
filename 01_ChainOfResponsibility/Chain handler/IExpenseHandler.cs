namespace _01_ChainOfResponsibility
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler next);
    }
}