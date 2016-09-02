namespace _02_Proxy_Employee
{
    public interface IEmployeeDataSource
    {
        EmployeeInfo GetEmployee(int id);
        void SaveEmployee(EmployeeInfo info);
    }
}
