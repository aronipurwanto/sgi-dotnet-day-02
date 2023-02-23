using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindApp.Context;
using NorthwindApp.Entity;

namespace NorthwindApp.Pages.Orders;

public class IndexModel : PageModel
{
    private NorthwindContext _context;
    public OrderEntity OrderData { get; set; }

    public IndexModel(NorthwindContext context)
    {
        _context = context;
    }
    public void OnGet(int? id)
    {
        OrderData = _context.Orders.Find(id);
    }
}