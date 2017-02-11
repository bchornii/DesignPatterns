using System;

namespace _01_ChainOfResponsibility
{
    internal class Program
    {
        private static void Main()
        {
            var william = new ExpenceHandler(new Employee("William Worker", decimal.Zero));
            var mary = new ExpenceHandler(new Employee("Mary Manager", new decimal(1000)));
            var victor = new ExpenceHandler(new Employee("Victor Vicepres", new decimal(5000)));
            var paula = new ExpenceHandler(new Employee("Paula President", new decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            decimal expenceReportAmount;
            while (ConsoleInput.TryReadDecimal("Expence report amount: ", out expenceReportAmount))
            {
                IExpenseReport expense = new ExpenseReport(expenceReportAmount);
                ApprovalResponse response = william.Approve(expense);
                Console.WriteLine($"The request was {response}");
            }

            Console.ReadLine();
        }
    }
}
