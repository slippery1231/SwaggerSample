using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwaggerSample.Service.Implement;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Controller;

public class EmployeeController : ControllerBase
{
    /// <summary>
    /// 取得單筆員工資料
    /// </summary>
    /// <param name="employeeId"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("api/employee")]
    [AllowAnonymous]
    public List<Employee> GetEmployee([FromQuery]Guid employeeId)
    {
        var employeeBl = new EmployeeBl(employeeId);
        return employeeBl.GetEmployee(employeeId);
    }
    
}
