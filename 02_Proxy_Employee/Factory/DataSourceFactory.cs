namespace _02_Proxy_Employee
{
    public class DataSourceFactory
    {
        public static IEmployeeDataSource Instance
        {
            get { return new EmployeeDataSourceProxy(); }
        }
    }
}
