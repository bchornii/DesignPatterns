namespace _02_Proxy_virtual
{
    public interface IEmployeeDataSource
    {
        EmployeeInfo GetEmployeeInfo(int id);
        void SetEmployeeInfo(EmployeeInfo employeeInfo);
    }
}
