using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NorthwindApp.Context;
using NorthwindApp.Entity;
using NorthwindApp.Models;

namespace NorthwindApp.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly NorthwindApp.Context.NorthwindContext _context;

        public CreateModel(NorthwindApp.Context.NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryModel CategoryModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Categories == null || CategoryModel == null)
            {
                return Page();
            }

            _context.Categories.Add(new CategoryEntity(CategoryModel));
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
