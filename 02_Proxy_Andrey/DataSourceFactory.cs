namespace _02_Proxy_Andrey
{
    public class DataSourceFactory
    {
        public static IEmployeeDataSource CreateEmployeeDataSource()
        {
            //return EmployeeDataSourceProxy.Instance;
            return new EmployeeDataSource();
        }
    }
}
