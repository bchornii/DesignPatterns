namespace _02_Proxy_Andrey
{
    public interface IEmployeeDataSource
    {
        EmployeeInfo GetEmployeeInfo(int id);
        void SetEmployeeInfo(EmployeeInfo info);
    }
}
