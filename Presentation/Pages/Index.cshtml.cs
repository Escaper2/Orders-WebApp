using System.Collections.ObjectModel;
using Application.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Pages.Orders;

public class Index : PageModel
{
    private readonly IOrdersService _ordersService;

    public Index(IOrdersService ordersService)
    {
        _ordersService = ordersService;
    }

    public List<Order> AllOrders { get; set; }

    public async Task<IActionResult> OnGetAsync(CancellationToken cancellationToken)
    {
        var lst = await _ordersService.GetAllAsync(cancellationToken);

        AllOrders = lst.ToList();

        return Page();

    }
}