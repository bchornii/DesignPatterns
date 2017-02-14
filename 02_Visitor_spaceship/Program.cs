using System;

namespace _02_Visitor_spaceship
{
    internal class Program
    {
        private static void Main()
        {           
            Console.Read();
        }
    }

    public abstract class Employee
    {
        public abstract void Accept(IEmployeeVisitor visitor);
    }

    public class HourlyEmployee : Employee
    {
        public override void Accept(IEmployeeVisitor visitor)
        {
            // generate report
        }
    }

    public class SalaryEmployee : Employee
    {
        public override void Accept(IEmployeeVisitor visitor)
        {
            // generate report
        }
    }

    public interface IEmployeeVisitor
    {
        void Visit(HourlyEmployee employee);
        void Visit(SalaryEmployee employee);
    }

}
