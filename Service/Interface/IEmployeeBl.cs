using SwaggerSample.Controller;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Service.Interface;

public interface IEmployeeBl
{
    public List<Employee> GetEmployee(Guid employeeId);

}