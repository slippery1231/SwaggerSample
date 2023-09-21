namespace SwaggerSample.ViewModel;

public class Customer
{
    /// <summary>
    /// 客戶姓名
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// 客戶ID
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// 客戶生日
    /// </summary>
    public string Birthday { get; set; }
}