using DataAccess.Models;

namespace Application.Services;

public interface IOrdersService
{
    
    Task<Order> CreateOrderAsync(string senderCity, string senderLocation, string recipientCity,
        string recipientLocation, uint loadWeight, DateOnly pickupDate, CancellationToken cancellationToken);
    
    Task<List<Order>> GetAllAsync(CancellationToken cancellationToken); 
    
    Task<Order> GetOneAsync(uint orderId, CancellationToken cancellationToken);
    
}