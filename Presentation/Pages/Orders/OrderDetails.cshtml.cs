using Application.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Pages.Orders;

public class OrderDetails : PageModel
{
    private readonly IOrdersService _ordersService;

    public OrderDetails(IOrdersService ordersService)
    {
        _ordersService = ordersService;
    }
    
    public Order Order { get; private set; }
    
    public async Task<IActionResult> OnGetAsync(uint id, CancellationToken cancellationToken)
    {
        Order = await _ordersService.GetOneAsync(id, cancellationToken);

        return Page();
    }
}