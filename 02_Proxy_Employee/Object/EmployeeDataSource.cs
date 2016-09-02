using System;
using System.Collections.Concurrent;
using System.Threading;

namespace _02_Proxy_Employee
{
    public class EmployeeDataSource : IEmployeeDataSource
    {
        private static ConcurrentDictionary<int, EmployeeInfo> _database =
                                    new ConcurrentDictionary<int, EmployeeInfo>();
        public EmployeeInfo GetEmployee(int id)
        {
            Console.WriteLine("Loading information abour employee ID = {0} (object)", id);
            Thread.Sleep(2000);
            return _database.GetOrAdd(id, CreateEmployee(id));
        }

        public void SaveEmployee(EmployeeInfo info)
        {
            Console.WriteLine("Saving employee Id={0},Name={1} (object)", info.Id, info.Name);
            Thread.Sleep(1000);
            _database.AddOrUpdate(info.Id, info, (id, emp) => info);
        }

        private EmployeeInfo CreateEmployee(int id)
        {
            return new EmployeeInfo
            {
                Id = id,
                Name = "[No name]"
            };
        }
    }
}
