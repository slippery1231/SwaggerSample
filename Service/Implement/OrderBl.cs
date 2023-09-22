using SwaggerSample.Service.Interface;
using SwaggerSample.ViewModel;

namespace SwaggerSample.Service.Implement;

public class OrderBl : IOrderBl
{
    //模擬資料庫資料
    private readonly List<Order> _allOrders = new List<Order>
    {
        new()
        {
            CustomerId = Guid.Parse("86ad94af-7e32-465e-8f1d-3e9185c5e96f"),
            BookingDate = "2023-09-21",
            OrderId = new Guid("8400643A-9453-41FA-BFBB-7E9A6D5426A2"),
            ItemName = "Mouse",
            Amount = 990m,
        },
        new()
        {
            CustomerId = Guid.Parse("cefdd7ab-0c6e-4cc5-9cf0-37d4c72c32d7"),
            BookingDate = "2023-09-19",
            OrderId = new Guid("F1A27982-C07C-4496-A061-8528361CE79C"),
            ItemName = "Keyboard",
            Amount = 1990m,
        },
        new()
        {
            CustomerId = Guid.Parse("f725c189-7ef1-4834-89fc-d4e2c11b6e68"),
            BookingDate = "2018-02-21",
            OrderId = new Guid("C85D9610-2652-421B-9F19-12C8C96D1710"),
            ItemName = "Monitor",
            Amount = 5990m,
        },
        new()
        {
            CustomerId = Guid.Parse("86ad94af-7e32-465e-8f1d-3e9185c5e96f"),
            BookingDate = "2023-05-31",
            OrderId = new Guid("68729CCC-4C48-4082-9DA6-457799A02B0E"),
            ItemName = "Book",
            Amount = 300m,
        },
        new()
        {
            CustomerId = Guid.Parse("cefdd7ab-0c6e-4cc5-9cf0-37d4c72c32d7"),
            BookingDate = "2020-07-11",
            OrderId = new Guid("0C318084-9207-495E-953E-0FF6D71D94A3"),
            ItemName = "USB",
            Amount = 200m,
        },
    };

    public List<Order> GetAllOrders()
    {
        return _allOrders;
    }

    public List<Order> GetSingleOrder(string date, Guid customerId)
    {
        return _allOrders.Where(x => x.BookingDate == date && x.CustomerId == customerId).ToList();
    }
}