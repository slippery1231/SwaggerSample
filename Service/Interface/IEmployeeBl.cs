using SwaggerSample.Controller;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Service.Interface;

public interface IEmployeeBl
{
    public List<Employee> GetAllEmployee();
    public List<Employee> GetEmployee(Guid employeeId);

    public void CreateEmployee(Employee employee);
}