using System;
using System.Collections.Concurrent;

namespace _02_Proxy_virtual
{
    public class EmployeeDataSourceProxy : IEmployeeDataSource
    {
        private static readonly Lazy<EmployeeDataSourceProxy> _instance;
        private static readonly ConcurrentDictionary<int, EmployeeInfo> _cache;
        private readonly IEmployeeDataSource _dataSource = new EmployeeDataSource();        

        public static EmployeeDataSourceProxy Instance => _instance.Value;

        static EmployeeDataSourceProxy()
        {
            _instance = new Lazy<EmployeeDataSourceProxy>(() => new EmployeeDataSourceProxy());
            _cache = new ConcurrentDictionary<int, EmployeeInfo>();
        }

        private EmployeeDataSourceProxy()
        {
            Console.WriteLine("EmployeeDataSourceProxy ctor...");
            Console.WriteLine(new string('-', 80));
        }

        public EmployeeInfo GetEmployeeInfo(int id)
        {
            return _cache.GetOrAdd(id, _dataSource.GetEmployeeInfo);
        }

        public void SetEmployeeInfo(EmployeeInfo employeeInfo)
        {
            _dataSource.SetEmployeeInfo(employeeInfo);
            _cache.AddOrUpdate(employeeInfo.Id, employeeInfo, (key, value) => employeeInfo);
        }
    }
}
