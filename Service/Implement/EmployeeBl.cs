using SwaggerSample.Service.Interface;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Service.Implement;

public class EmployeeBl : IEmployeeBl
{
    //這邊先用List模擬DB情況
    private readonly List<Employee> _employeeList = new()
    {
        new Employee
        {
            Name = "Alvin",
            EmployeeId = Guid.Parse("86ad94af-7e32-465e-8f1d-3e9185c5e96f"),
            EmployeeNumber = "S001"
        },
        new Employee
        {
            Name = "Ben",
            EmployeeId = Guid.Parse("cefdd7ab-0c6e-4cc5-9cf0-37d4c72c32d7"),
            EmployeeNumber = "S002"
        },
        new Employee
        {
            Name = "Calvin",
            EmployeeId = Guid.Parse("f725c189-7ef1-4834-89fc-d4e2c11b6e68"),
            EmployeeNumber = "S003"
        },
    };

    public EmployeeBl(Guid employeeId)
    {
    }


    public List<Employee> GetAllEmployee()
    {
        return _employeeList;
    }

    public List<Employee> GetEmployee(Guid employeeId)
    {
        return _employeeList.Where(x => x.EmployeeId == employeeId).ToList();
    }

    public void CreateEmployee(Employee employee)
    {
        if (employee != null)
        {
            _employeeList.Add(employee);
        }
        else
        {
            throw new Exception("資料有誤");
        }

    }
}