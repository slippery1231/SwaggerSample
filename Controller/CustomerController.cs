using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwaggerSample.Service.Interface;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Controller;

public class CustomerController : ControllerBase
{
    private readonly ICustomerBl _customerBl;

    public CustomerController(ICustomerBl customerBl)
    {
        _customerBl = customerBl;
    }

    /// <summary>
    /// 取得全部員工資料
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("api/customer/getall")]
    // [AllowAnonymous]
    public List<Customer> GetAllCustomers()
    {
        return _customerBl.GetAllEmployee();
    }

    /// <summary>
    /// 取得單筆員工資料
    /// </summary>
    /// <param name="customerId">客戶ID</param>
    /// <returns></returns>
    [HttpGet]
    [Route("api/customer")]
    [AllowAnonymous]
    public List<Customer> GetSingleCustomer([FromQuery] Guid customerId)
    {
        return _customerBl.GetEmployee(customerId);
    }

    [HttpPost]
    [Route("api/customer/add")]
    [AllowAnonymous]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Customer))]
    [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
    public IActionResult AddCustomers([FromBody] Customer customer)
    {
        if (customer == null)
        {
            return BadRequest("傳入為Null");
        }
        _customerBl.CreateEmployee(customer);
        return Ok(customer);
    }
}