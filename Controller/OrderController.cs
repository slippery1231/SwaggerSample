using Microsoft.AspNetCore.Mvc;
using SwaggerSample.Service.Interface;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Controller;

public class OrderController : ControllerBase
{
    private readonly IOrderBl _orderBl;

    public OrderController(IOrderBl orderBl)
    {
        _orderBl = orderBl;
    }

    /// <summary>
    /// 取得全部訂單資料
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("api/order/getallorders")]
    public List<Order> GetAllOrders()
    {
        return _orderBl.GetAllOrders();
    }

    /// <summary>
    /// 取得客戶在某日期的訂單
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("api/order/getsingleorder")]
    public List<Order> GetSingleOrder(string date, Guid customerId)
    {
        return _orderBl.GetSingleOrder(date,customerId);
    }
}