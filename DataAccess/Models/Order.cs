namespace DataAccess.Models;

public class Order
{
    public Order(uint orderId, string senderCity, string senderLocation, string recipientCity, string recipientLocation, uint loadWeight, DateOnly pickupDate)
    {
        OrderId = orderId;
        SenderCity = senderCity;
        SenderLocation = senderLocation;
        RecipientCity = recipientCity;
        RecipientLocation = recipientLocation;
        LoadWeight = loadWeight;
        PickupDate = pickupDate;
    }

    public uint OrderId { get; set; }
    public string SenderCity { get; set; }
    public string SenderLocation { get; set; }
    public string RecipientCity { get; set; }
    public string RecipientLocation { get; set; }
    public uint LoadWeight { get; set; }
    public DateOnly PickupDate { get; set; }
}