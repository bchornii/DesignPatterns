using System;

namespace _02_Proxy_virtual
{
    internal class Program
    {
        private static void ShowEmployeeInfo(int id, IEmployeeDataSource dataSource)
        {
            var employeeInfo = dataSource.GetEmployeeInfo(id);
            Console.WriteLine($"Employee id = {employeeInfo.Id}");
            Console.WriteLine($"Employee name = {employeeInfo.Name}\n");
        }

        private static void SetEmployeeName(int id, string fullName, IEmployeeDataSource dataSource)
        {
            var employeeInfo = dataSource.GetEmployeeInfo(id);
            employeeInfo.Name = fullName;
            dataSource.SetEmployeeInfo(employeeInfo);
        }

        private static void Main(string[] args)
        {
            IEmployeeDataSource dataSource = DataSourceFactory.CreateEmployeeDataSource();

            ShowEmployeeInfo(11, dataSource);
            ShowEmployeeInfo(12, dataSource);

            SetEmployeeName(11, "Employee 1 name", dataSource);            
            SetEmployeeName(12, "Employee 2 name", dataSource);
            Console.WriteLine();

            ShowEmployeeInfo(11, dataSource);
            ShowEmployeeInfo(12, dataSource);

            Console.WriteLine("\nDone ...");
            Console.ReadKey(true);
        }
    }
}
