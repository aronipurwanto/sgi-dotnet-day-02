using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindApp.Models;

namespace NorthwindApp.Pages.Custom;

public class IndexModel : PageModel
{
    public Person Person { get; set; }
    public void OnGet()
    {
        List<PersonAddress> addresses = new List<PersonAddress>()
        {
            new PersonAddress(1, "Jakarta", "Jakarta Address"),
            new PersonAddress(1, "Pemalang", "Pemalang Address")
        };
        Person = new Person(1, "Nicky", addresses);
    }
}