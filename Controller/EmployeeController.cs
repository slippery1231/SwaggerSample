using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwaggerSample.Service.Interface;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Controller;

public class EmployeeController : ControllerBase
{
    private readonly IEmployeeBl _employeeBl;

    public EmployeeController(IEmployeeBl employeeBl)
    {
        _employeeBl = employeeBl;
    }

    /// <summary>
    /// 取得全部員工資料
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("api/employee/getall")]
    [AllowAnonymous]
    public List<Employee> GetAllEmployee()
    {
        return _employeeBl.GetAllEmployee();
    }

    /// <summary>
    /// 取得單筆員工資料
    /// </summary>
    /// <param name="employeeId"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("api/employee")]
    [AllowAnonymous]
    public List<Employee> GetEmployee([FromQuery] Guid employeeId)
    {
        return _employeeBl.GetEmployee(employeeId);
    }
}