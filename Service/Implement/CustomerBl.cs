using SwaggerSample.Service.Interface;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Service.Implement;

public class CustomerBl : ICustomerBl
{
    //這邊先用List模擬DB情況
    private readonly List<Customer> _employeeList = new()
    {
        new Customer
        {
            Name = "Alvin",
            CustomerId = Guid.Parse("86ad94af-7e32-465e-8f1d-3e9185c5e96f"),
            Birthday = "1995-01-21"
        },
        new Customer
        {
            Name = "Ben",
            CustomerId = Guid.Parse("cefdd7ab-0c6e-4cc5-9cf0-37d4c72c32d7"),
            Birthday = "1987-02-23"
        },
        new Customer
        {
            Name = "Calvin",
            CustomerId = Guid.Parse("f725c189-7ef1-4834-89fc-d4e2c11b6e68"),
            Birthday = "1992-12-31"
        },
    };


    public List<Customer> GetAllEmployee()
    {
        return _employeeList;
    }

    public List<Customer> GetEmployee(Guid employeeId)
    {
        return _employeeList.Where(x => x.CustomerId == employeeId).ToList();
    }

    public void CreateEmployee(Customer customer)
    {
        _employeeList.Add(customer);
    }
}