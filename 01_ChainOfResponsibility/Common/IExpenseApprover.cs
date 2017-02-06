namespace _01_ChainOfResponsibility
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }
}