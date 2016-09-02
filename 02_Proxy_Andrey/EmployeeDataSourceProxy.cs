using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Proxy_Andrey
{
    public class EmployeeDataSourceProxy : IEmployeeDataSource
    {
        private static Lazy<EmployeeDataSourceProxy> _proxyInstance = 
            new Lazy<EmployeeDataSourceProxy>(() => new EmployeeDataSourceProxy());

        public static EmployeeDataSourceProxy Instance
        {
            get { return _proxyInstance.Value; }
        }

        private EmployeeDataSourceProxy()
        {
            Console.WriteLine("Employee proxy ctor...");
        }

        private readonly IEmployeeDataSource _dataSource = new EmployeeDataSource();
        private static ConcurrentDictionary<int, EmployeeInfo> _cache =
                                    new ConcurrentDictionary<int, EmployeeInfo>();
        public EmployeeInfo GetEmployeeInfo(int id)
        {
            return _cache.GetOrAdd(id, _dataSource.GetEmployeeInfo);
        }

        public void SetEmployeeInfo(EmployeeInfo info)
        {
            _dataSource.SetEmployeeInfo(info);
            _cache.AddOrUpdate(info.Id, info, (id, emp) => info);
        }
    }
}
