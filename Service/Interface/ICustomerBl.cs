using SwaggerSample.Controller;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Service.Interface;

public interface ICustomerBl
{
    public List<Customer> GetAllEmployee();
    public List<Customer> GetEmployee(Guid employeeId);

    public void CreateEmployee(Customer customer);
}