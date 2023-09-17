using SwaggerSample.Service.Interface;
using SwaggerSample.ViewModel;
using System.Collections.Generic;

namespace SwaggerSample.Service.Implement;

public class EmployeeBl : IEmployeeBl
{
    public EmployeeBl(Guid employeeId)
    {
    }

    public List<Employee> GetEmployee(Guid employeeId)
    {
        //這邊先用List模擬DB情況
        var employeeList = new List<Employee>
        {
            new()
            {
                Name = "Alvin", 
                EmployeeId = Guid.Parse("86ad94af-7e32-465e-8f1d-3e9185c5e96f"),
                EmployeeNumber = "S001"
            },
            new()
            {
                Name = "Ben", 
                EmployeeId = Guid.Parse("cefdd7ab-0c6e-4cc5-9cf0-37d4c72c32d7"),
                EmployeeNumber = "S002"
            },
            new()
            {
                Name = "Calvin", 
                EmployeeId = Guid.Parse("f725c189-7ef1-4834-89fc-d4e2c11b6e68"),
                EmployeeNumber = "S003"
            },
        };
        return employeeList.Where(x => x.EmployeeId == employeeId).ToList();
    }
}