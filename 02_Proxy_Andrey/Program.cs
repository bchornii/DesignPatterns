using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Proxy_Andrey
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDataSource dataSource = DataSourceFactory.CreateEmployeeDataSource();

            ShowEmployeeInfo(1, dataSource);
            ShowEmployeeInfo(2, dataSource);

            SetEmployeeName(1, "ivan", dataSource);
            SetEmployeeName(2, "bohdan", dataSource);

            ShowEmployeeInfo(1, dataSource);
            ShowEmployeeInfo(2, dataSource);

            Console.ReadLine();
        }

        static void ShowEmployeeInfo(int id, IEmployeeDataSource dataSource)
        {
            EmployeeInfo info = dataSource.GetEmployeeInfo(id);
            Console.WriteLine("Employee id = {0}", info.Id);
            Console.WriteLine("Employee first name = {0}", info.FirstName);
        }

        static void SetEmployeeName(int id, string firstName, IEmployeeDataSource dataSource)
        {
            EmployeeInfo info = dataSource.GetEmployeeInfo(id);
            info.FirstName = firstName;
            dataSource.SetEmployeeInfo(info);
        }
    }
}
