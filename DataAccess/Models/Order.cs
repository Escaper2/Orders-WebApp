using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class Order
{
    public Order( string senderCity, string senderLocation, string recipientCity, string recipientLocation, uint loadWeight, DateOnly pickupDate)
    {
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