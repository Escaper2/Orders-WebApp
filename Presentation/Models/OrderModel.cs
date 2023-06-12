namespace Presentation.Models;

public class OrderModel
{
    public string SenderCity { get; set; }
    public string SenderLocation { get; set; }
    public string RecipientCity { get; set; }
    
    public string RecipientLocation { get; set; }
    public uint LoadWeight { get; set; }
    public DateOnly PickupDate { get; set; }
}
    