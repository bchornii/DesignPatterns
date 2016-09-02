using System;
using System.Collections.Concurrent;

namespace _02_Proxy_Employee
{
    public class EmployeeDataSourceProxy : IEmployeeDataSource
    {
        private static ConcurrentDictionary<int, EmployeeInfo> _proxyCache =
            new ConcurrentDictionary<int, EmployeeInfo>();
        private readonly IEmployeeDataSource _object = new EmployeeDataSource();
        public EmployeeInfo GetEmployee(int id)
        {
            Console.WriteLine("Loading information about employee ID = {0} (cache)", id);
            return _proxyCache.GetOrAdd(id, _object.GetEmployee);
        }

        public void SaveEmployee(EmployeeInfo info)
        {
            Console.WriteLine("Save information about employee : ID = {0}, Name = {1} (cache)", info.Id, info.Name);
            _object.SaveEmployee(info);
            _proxyCache.AddOrUpdate(info.Id, info, (id, emp) => info);            
        }
    }
}
