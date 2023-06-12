using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models;

namespace Presentation.Pages.Orders;

public class CreateOrder : PageModel
{
    private IOrdersService _ordersService;

    public CreateOrder(IOrdersService ordersService)
    {
        _ordersService = ordersService;
    }

    [BindProperty] 
    public OrderModel OrderModel { get; set; } = new();

    public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
    {
        await _ordersService.CreateOrderAsync(OrderModel.SenderCity, OrderModel.SenderLocation,
            OrderModel.RecipientCity, OrderModel.RecipientLocation,
            OrderModel.LoadWeight, OrderModel.PickupDate, cancellationToken);
        
        TempData["SuccessMessage"] = $"Order from {OrderModel.SenderCity} to {OrderModel.RecipientCity} was created!";

        return RedirectToPage("/Index");
    }
    
    
    public void OnGet()
    {
        
    }
}