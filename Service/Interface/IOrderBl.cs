using SwaggerSample.ViewModel;

namespace SwaggerSample.Service.Interface;

public interface IOrderBl
{
    public List<Order> GetAllOrders();
    public List<Order> GetSingleOrder(string date, Guid customerId);
}