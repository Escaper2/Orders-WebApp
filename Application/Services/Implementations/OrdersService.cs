using Application.Exceptions;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementations;

public class OrdersService : IOrdersService
{
    private readonly DatabaseContext _context;

    public OrdersService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<Order> CreateOrderAsync(string senderCity, string senderLocation, string recipientCity,
        string recipientLocation, uint loadWeight, DateOnly pickupDate, CancellationToken cancellationToken)
    {

        var order = new Order(senderCity, senderLocation, recipientCity, recipientLocation, loadWeight,
            pickupDate);

        _context.Orders.Add(order);
        
        await _context.SaveChangesAsync(cancellationToken);

        return order;
    }

    public async Task<List<Order>> GetAllAsync(CancellationToken cancellationToken)
    {
        var orders = await _context.Orders.AsNoTracking().ToListAsync(cancellationToken);

        return orders;
    }

    public async Task<Order> GetOneAsync(uint orderId, CancellationToken cancellationToken)
    {
        var order = await _context.Orders.FindAsync(new object[] { orderId }, cancellationToken);

        if (order is null || order.OrderId != orderId) throw NotFoundException<Order>.ThrowException(orderId);

        return order;
    }
}