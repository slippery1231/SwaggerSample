namespace SwaggerSample.ViewModel;

public class Order
{
    /// <summary>
    /// 訂單流水編號
    /// </summary>
    public Guid OrderId { get; set; }
    
    /// <summary>
    /// 訂購日期
    /// </summary>
    public string BookingDate { get; set; }
    
    /// <summary>
    /// 客戶ID
    /// </summary>
    public Guid CustomerId { get; set; }
    
    /// <summary>
    /// 商品名稱
    /// </summary>
    public string ItemName { get; set; }

    /// <summary>
    /// 訂單金額
    /// </summary>
    public decimal Amount { get; set; }
}