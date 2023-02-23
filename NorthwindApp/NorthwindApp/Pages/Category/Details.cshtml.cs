using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Context;
using NorthwindApp.Models;

namespace NorthwindApp.Pages.Category
{
    public class DetailsModel : PageModel
    {
        private readonly NorthwindApp.Context.NorthwindContext _context;

        public DetailsModel(NorthwindApp.Context.NorthwindContext context)
        {
            _context = context;
        }

      public CategoryModel CategoryModel { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var entity = await _context.Categories.FirstOrDefaultAsync(m => m.CategoryId == id);
            if (entity == null)
            {
                return NotFound();
            }
            else 
            {
                CategoryModel = new CategoryModel(entity);
            }
            return Page();
        }
    }
}
