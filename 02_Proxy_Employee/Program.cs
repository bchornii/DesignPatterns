using System;

namespace _02_Proxy_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDataSource dataSource = DataSourceFactory.Instance;

            ShowEmployee(1, dataSource);
            ShowEmployee(2, dataSource);

            SaveEmployee(1, "bogdan", dataSource);
            SaveEmployee(2, "andrey", dataSource);

            ShowEmployee(1, dataSource);
            ShowEmployee(2, dataSource);

            Console.Read();
        }

        static void ShowEmployee(int id, IEmployeeDataSource dataSource)
        {
            EmployeeInfo info = dataSource.GetEmployee(id);
            Console.WriteLine("Id = {0}", info.Id);
            Console.WriteLine("Name = {0}", info.Name);
        }

        static void SaveEmployee(int id,string name,IEmployeeDataSource dataSource)
        {
            EmployeeInfo info = dataSource.GetEmployee(id);
            info.Id = id;
            info.Name = name;
            dataSource.SaveEmployee(info);
        }
    }
}
