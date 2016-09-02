using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Proxy_Andrey
{
    public class EmployeeDataSource : IEmployeeDataSource
    {
        private static ConcurrentDictionary<int, EmployeeInfo> _database =
                                    new ConcurrentDictionary<int, EmployeeInfo>();

        public EmployeeDataSource()
        {
            Console.WriteLine("EmployeeDataSource ctor...");
        }

        public EmployeeInfo GetEmployeeInfo(int id)
        {
            Console.WriteLine("Loading information abour employee id = {0}", id);
            Thread.Sleep(2000);
            return _database.GetOrAdd(id, CreateNewEmployee(id));
        }

        public void SetEmployeeInfo(EmployeeInfo info)
        {
            Console.WriteLine("Savind employee ({0},{1}) to database...", info.Id, info.FirstName);
            Thread.Sleep(1000);
            _database.AddOrUpdate(info.Id, info, (id, emp) => info);
        }

        private EmployeeInfo CreateNewEmployee(int id)
        {
            return new EmployeeInfo
            {
                Id = id,
                FirstName = "[No Name]"
            };
        }
    }
}
