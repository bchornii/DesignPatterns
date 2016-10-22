using System;
using System.Collections.Concurrent;
using System.Threading;

namespace _02_Proxy_virtual
{
    public class EmployeeDataSource : IEmployeeDataSource
    {
        private static readonly ConcurrentDictionary<int, EmployeeInfo> _db
            = new ConcurrentDictionary<int, EmployeeInfo>();

        public EmployeeDataSource()
        {
            Console.WriteLine("EmployeeDataSource ctor...");
            Console.WriteLine(new string('-', 80));
        }

        public EmployeeInfo GetEmployeeInfo(int id)
        {
            Console.WriteLine($"Load {id} from database...");
            Thread.Sleep(1000);

            return _db.GetOrAdd(id, key => new EmployeeInfo { Id = key, Name = "[NoName]" });
        }

        public void SetEmployeeInfo(EmployeeInfo employeeInfo)
        {
            Console.WriteLine($"Saving ({employeeInfo.Id}:{employeeInfo.Name}) to database...");
            _db.AddOrUpdate(employeeInfo.Id, employeeInfo, (key, value) => employeeInfo);
        }
    }
}
