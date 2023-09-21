using Microsoft.AspNetCore.Mvc;
using SwaggerSample.Service.Implement;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Controller;

public class OrderController : ControllerBase
{
    /// <summary>
    /// 取得全部訂單資料
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("api/order/getallorders")]
    public List<Order> GetAllEmployee()
    {
        var orderBl = new OrderBl();
        return orderBl.GetAllOrders();
    }
}