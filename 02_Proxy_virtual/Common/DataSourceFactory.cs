namespace _02_Proxy_virtual
{
    public static class DataSourceFactory
    {
        public static IEmployeeDataSource CreateEmployeeDataSource()
        {
            //return new EmployeeDataSource();
            return EmployeeDataSourceProxy.Instance;
        }
    }
}
